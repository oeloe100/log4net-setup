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
        //log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly log4net.ILog log = LogHelper.GetLogger();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            log.Error("This is my error message");

            Console.ReadLine();
        }
    }
}
