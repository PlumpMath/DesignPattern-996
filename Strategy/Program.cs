using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context(new XmlSerializer());
            ctx.Serialize();
        }
    }
}
