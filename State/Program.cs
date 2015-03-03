using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            AlertStateContext stateContext = new AlertStateContext();
            stateContext.Alert();
            stateContext.Alert();
            stateContext.SetState(new Silent());
            stateContext.Alert();
            stateContext.Alert();
            stateContext.Alert();	
        }
    }
}
