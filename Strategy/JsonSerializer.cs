using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    public class JsonSerializer : ISerializer
    {

        public void Serialize()
        {
            Console.WriteLine("JSON");
        }
    }
}
