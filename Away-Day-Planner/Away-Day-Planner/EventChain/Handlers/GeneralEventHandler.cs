using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.EventChain.Handlers
{
    internal class GeneralEventHandler : Handler
    {
        public void AddOption()
        {
        }

        public override void ChangeEventState()
        {
            Event.EventState = EVENT_STATE.PAYMENT;
        }

        public override void HandleEvent()
        {
            ChangeEventState();
            Successor.HandleEvent();
        }
    }
}
