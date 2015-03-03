using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {
        private static readonly Logger _instance = new Logger();
        private Logger()
        {

        }
        public static Logger GetInstance()
        {
            return _instance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var logger1 = Logger.GetInstance();
            var logger2 = Logger.GetInstance();
            Console.WriteLine(logger1.GetHashCode()==logger2.GetHashCode());
        }
    }
}
