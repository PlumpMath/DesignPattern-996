using System;
using System.Collections.Generic;
using System.Linq;

namespace State
{
    public interface IMobileAlertState
    {
         void Alert(AlertStateContext ctx);
    }
}
