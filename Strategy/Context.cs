using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    public class Context
    {
        private ISerializer _serializer;
        public Context(ISerializer serializer)
        {
            this._serializer = serializer;

        }
        public void Serialize()
        {
            _serializer.Serialize();
        }
    }
}
