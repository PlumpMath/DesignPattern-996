using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer.Win
{
    public interface ICounterSubject
    {
        void Attach(IObserver observer);
        void Remove(IObserver observer);
        void Notify(int counter);
    }
}
