using System;
using System.Collections.Generic;
using System.Linq;

namespace State
{
    public class Silent : IMobileAlertState
    {
        public void Alert(AlertStateContext ctx)
        {
            Console.WriteLine("Silent");
        }
    }
}
