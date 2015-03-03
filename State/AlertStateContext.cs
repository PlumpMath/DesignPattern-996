using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public class AlertStateContext
    {
        private IMobileAlertState currentState;

        public AlertStateContext()
        {
            currentState = new Vibration();
        }

        public void SetState(IMobileAlertState state)
        {
            currentState = state;
        }

        public void Alert()
        {
            currentState.Alert(this);
        }
    }
}
