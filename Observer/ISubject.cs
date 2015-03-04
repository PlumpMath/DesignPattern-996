using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);

        void Notify();

        void UnRegisterObserver(IObserver observer);

        Object GetUpdate();

    }
}
