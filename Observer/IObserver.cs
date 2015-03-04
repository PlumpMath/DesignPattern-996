using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer
{
    public interface IObserver
    {

        void Notify();


        void SetSubject(ISubject subject);
    }
}
