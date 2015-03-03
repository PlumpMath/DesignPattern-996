using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Visitor
{
    public interface IValidatable<T>
    {
        bool Validate(IValidator<T> validator, out IEnumerable<string> brokenRules);
    }
}
