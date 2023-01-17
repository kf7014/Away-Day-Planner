    using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.EventChain.Handlers
{
    internal class BaseEventHandler : Handler
    {
        public void SetEvent(IEvent e)
        {
            Event = e;
        }
        public override void HandleEvent()
        {
            Event.CurrentHandler = Successor;
        }
    }
}
