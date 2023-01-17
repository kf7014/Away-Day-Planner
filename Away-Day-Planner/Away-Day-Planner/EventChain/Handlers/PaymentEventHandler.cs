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
        public int GetFinalCost() { return FinalCost; }
        private void CalculateFinalCost(){}
        public override void HandleEvent()
        {
            Event.CurrentHandler = this;
            Event.EventState = EVENT_STATE.PAYMENT;
        }
    }
}
