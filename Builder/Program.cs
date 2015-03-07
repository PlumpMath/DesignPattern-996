using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder performanceBuilder = new FastAndFuriousCarBuilder();
            Mechanic mechanic = new Mechanic(performanceBuilder);
            mechanic.ConstructCar();
            var car = mechanic.GetCar();
           
            Console.WriteLine(car.Tires);
        }
    }
}
