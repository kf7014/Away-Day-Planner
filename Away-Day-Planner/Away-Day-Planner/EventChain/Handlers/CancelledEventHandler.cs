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
        public double CalculateCancelledPercentage(DateTime TimeNow) {
            double DayDiff = Event.DaysTillEvent(TimeNow);

            if (DayDiff > 60) return .20;
            if (DayDiff <= 60 && DayDiff >= 30) return .50;
            else return .75;
        }
        public double CalculateCancelledFee()
        {
            DateTime currentTime = DateTime.Now;
            return CalculateCancelledPercentage(currentTime);
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
