using System;
using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    public interface IPersonEnumerable
    {
        IPersonIterator GetIterator();
    }
}
