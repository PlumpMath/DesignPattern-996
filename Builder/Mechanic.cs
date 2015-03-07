using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder
{
    public class Mechanic
    {
        private CarBuilder carBuilder;

        public Mechanic(CarBuilder carBuilder)
        {
            this.carBuilder = carBuilder;
        }

        public Car GetCar()
        {
            return carBuilder.GetCar();
        }

        public void ConstructCar()
        {
            carBuilder.CreateNewCar();
            carBuilder.BuildEngine();
            carBuilder.BuildTires();
            carBuilder.BuildExhaust();
        }
    }
}
