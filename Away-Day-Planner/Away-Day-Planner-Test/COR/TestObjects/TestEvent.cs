using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.EventChain;
using Away_Day_Planner.EventChain.Handlers;

namespace Away_Day_Planner_Test.COR.TestObjects
{
    internal class TestEvent : IEvent
    {
        public EVENT_STATE EventState { get; set; }
        public IHandler? CurrentHandler { get; set; }
        public List<IHandler>? HandlerList { get; set; }
        public int id { get; set; }
    }
}
