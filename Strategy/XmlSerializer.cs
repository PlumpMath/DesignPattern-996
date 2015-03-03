using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    public class XmlSerializer : ISerializer
    {

        public void Serialize()
        {
            Console.WriteLine("XML");
        }
    }
}
