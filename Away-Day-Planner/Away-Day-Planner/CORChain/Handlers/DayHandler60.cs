/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009595
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.CORChain.Handlers
{
    public class DayHandler60 : Handler
    {
        public override void HandleEvent(IEvent Event)
        {
            if(Event.DaysTillEvent(DateTime.Now) > 60)
            {
                Event.EventState = EVENT_STATE.CANCELLED;
                Event.price *= .20M;
            }else
            {
                Successor.HandleEvent(Event);
            }
        }
    }
}
