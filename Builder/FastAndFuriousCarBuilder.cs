using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder
{
    public class FastAndFuriousCarBuilder : CarBuilder
    {
        public override void BuildEngine()
        {
            _car.Engine = "Twin Turbo with NOS";
        }
        public override void BuildTires()
        {
            _car.Tires = "19 inch low profile racing tires";
        }
        public override void BuildExhaust()
        {
            _car.Exhaust = "Deafening";
        }
      
    }
}
