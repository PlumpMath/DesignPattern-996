using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer.Win
{
    public interface IObserver
    {
        void Notify(int counter);
    }
}
