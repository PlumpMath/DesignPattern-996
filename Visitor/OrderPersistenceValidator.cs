using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Visitor
{
    public class OrderPersistenceValidator : IValidator<Order>
    {
        public bool IsValid(Order entity)
        {
            return BrokenRules(entity).Count() > 0;
        }

        public IEnumerable<string> BrokenRules(Order entity)
        {
            if (entity.Id < 0)
                yield return "Id cannot be less than 0.";

            if (string.IsNullOrEmpty(entity.Customer))
                yield return "Must include a customer.";

            yield break;
        }
    }
}
