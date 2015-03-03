using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
  public  class Vibration:IMobileAlertState
    {
        public void Alert(AlertStateContext ctx)
        {
            Console.WriteLine("Vibration");
        }
    }
}
