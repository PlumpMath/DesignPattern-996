using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Visitor
{
    public class Order : IValidatable<Order>
    {
        public int Id { get; set; }
        public string Customer { get; set; }

        public bool Validate(IValidator<Order> validator, out IEnumerable<string> brokenRules)
        {
            brokenRules = validator.BrokenRules(this);
            return validator.IsValid(this);
        }
    }
}
