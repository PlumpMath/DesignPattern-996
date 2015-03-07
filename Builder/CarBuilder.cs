using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder
{
    public abstract class CarBuilder
    {
        protected Car _car;
        public void CreateNewCar()
        {
            _car = new Car();
        }
        public Car GetCar()
        {
            return _car;
        }
        public abstract void BuildEngine();
        public abstract void BuildTires();
        public abstract void BuildExhaust();

    }
}
