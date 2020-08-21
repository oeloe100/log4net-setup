using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Log4net.Test.Application
{
    class Program
    {
        //Dont display full path (reflection)
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //Display full path
        //private static readonly log4net.ILog log = LogHelper.GetLogger();

        static void Main(string[] args)
        {
            //Different logging levels (stringmatchfilter in app.config searches for cases in the log (to match))
            log.Debug("Developer: Tutorial was run");
            log.Info("Maintenance: water pump turned on");
            log.Warn("Maintenance: waterpump is hot");

            var i = 0;

            try
            {
                var x = 10 / i;
            }
            catch (DivideByZeroException ex)
            {
                log.Error("Developer: we tried to divide by zero again");
            }

            Counter j = new Counter();

            log4net.GlobalContext.Properties["counter"] = j;

            for (j.LoopCounter = 0; j.LoopCounter < 5; j.LoopCounter++)
            {
                log.Fatal("This is a fatal error in the process: ");
            }

            /*
            for (i = 0; i < 5; i++)
            {
                //set custom property. place in app.config. Global is application wide. Can also setup with thread is more specific.
                //log4net.GlobalContext.Properties["counter"] = i;
                log.Fatal("This is a fatal error in the process: ");
            }*/

            //log.Fatal("Maintenance: water pump exploded");

            Console.ReadLine();
        }
    }
}
