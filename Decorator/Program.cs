using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes("santosh"));
            UpperStream UpperStream = new UpperStream(stream);
            StreamReader reader = new StreamReader(UpperStream);
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
