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
        public decimal CalculateCancelledPercentage(Event Event, DateTime TimeNow) {
            double DayDiff = Event.DaysTillEvent(TimeNow);

            if (DayDiff > 60) return 0.20M;
            if (DayDiff <= 60 && DayDiff >= 30) return 0.50M;
            else return 0.75M;
        }
        public Decimal CalculateCancelledFee(Event Event)
        {
            DateTime currentTime = DateTime.Now;
            return CalculateCancelledPercentage(Event, currentTime);
        }

        private void ApplyCancelledFeeDifference(Event Event)
        {
            Event.price *= CalculateCancelledFee(Event);
        }

        public override void HandleEvent(IEvent Event)
        {
            Successor.HandleEvent(Event);
        }
    }
}
