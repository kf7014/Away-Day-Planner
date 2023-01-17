using Away_Day_Planner.Models.EventBooker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.EventChain.Handlers
{
    internal class GeneralEventHandler : Handler
    {
        public override void HandleEvent(IEvent Event)
        {
            Successor.HandleEvent(Event);
        }
    }
}
