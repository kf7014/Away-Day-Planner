using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.EventChain.Handlers
{
    internal class PaymentEventHandler : Handler
    {
        private int FinalCost;
        public override void HandleEvent()
        {
            Successor.HandleEvent();
        }

        public override void ChangeEventState()
        {
            ChangeEventState();
            Event.EventState = EVENT_STATE.ARCHIVED;
        }
    }
}
