using Away_Day_Planner.Models.EventBooker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.EventChain.Handlers
{
    internal class CancelledEventHandler : Handler
    {
        public Decimal CalculateCancelledPercentage(DateTime TimeNow) {
            double DayDiff = Event.DaysTillEvent(TimeNow);

            if (DayDiff > 60) return 0.20M;
            if (DayDiff <= 60 && DayDiff >= 30) return 0.50M;
            else return 0.75M;
        }
        public Decimal CalculateCancelledFee()
        {
            DateTime currentTime = DateTime.Now;
            return CalculateCancelledPercentage(currentTime);
        }
        public override void ChangeEventState()
        {
            Event.EventState = EVENT_STATE.PAYMENT;
        }
        private void ApplyCancelledFeeDifference()
        {
            Event.price = Event.price * CalculateCancelledFee();
        }

        public override void HandleEvent()
        {
            ApplyCancelledFeeDifference();
            ChangeEventState();
            Successor.HandleEvent();
        }
    }
}
