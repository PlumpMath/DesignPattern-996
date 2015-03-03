using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Win
{
   public class CounterSubject:ICounterSubject
    {
       private List<IObserver> _list;
       private int _counter = 0;
       public CounterSubject()
       {
           _list = new List<IObserver>();
       }
        public void Attach(IObserver observer)
        {
            _list.Add(observer);
        }

        public void Increment()
        {
            _counter++;
            Notify(_counter);

        }
        public void Decrement()
        {
            if (_counter > 0)
                _counter--;
            Notify(_counter);

        }
        public void Remove(IObserver observer)
        {
            _list.Remove(observer);
        }

        public void Notify(int counter)
        {
            foreach (var item in _list)
            {
                item.Notify(counter);
            }
        }
    }
}
