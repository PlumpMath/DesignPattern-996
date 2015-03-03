using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Visitor
{
    public interface IValidator<T>
    {
        bool IsValid(T entity);
        IEnumerable<string> BrokenRules(T entity);
    }
}
