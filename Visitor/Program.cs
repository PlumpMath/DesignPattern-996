using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.Customer = "santosh";
            OrderPersistenceValidator validator = new OrderPersistenceValidator();

            IEnumerable<string> brokenRules;
            bool isValid = order.Validate(validator, out brokenRules);
            foreach (var item in brokenRules)
            {
                Console.WriteLine(item);
            }
        }
    }
}
