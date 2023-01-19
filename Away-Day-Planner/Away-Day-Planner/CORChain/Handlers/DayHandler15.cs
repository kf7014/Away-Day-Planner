using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.CORChain.Handlers
{
    internal class DayHandler15 : Handler
    {
        public override void HandleEvent(IEvent Event)
        {
            if (Event.DaysTillEvent(DateTime.Now) > 15)
            {
                Event.EventState = EVENT_STATE.CANCELLED;
                Event.price *= .75M;
            }
            else return;
        }
    }
}
