using System;
using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    public interface IPersonIterator
    {
        void MoveFirst();
        void Reset();
        bool MoveNext();
        Person Current { get; }
    }
}
