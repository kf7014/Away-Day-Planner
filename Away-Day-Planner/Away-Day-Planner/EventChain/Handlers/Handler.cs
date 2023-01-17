using Away_Day_Planner.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.EventChain.Handlers
{
    internal abstract class Handler : IHandler
    {
        public readonly Dictionary<string, Exception> Errors = ErrorList.EventErrors;
        protected IHandler Successor { get; set; }
        protected IEvent Event { get; set; }
        protected IHandler CancelledSuccessor { get; set; }

        public virtual void SetSuccessor(IHandler h) 
        { 
            Successor = h;
        }
        public virtual void SetCancelledSuccessor(IHandler h)
        {
            CancelledSuccessor = h;
        }
        public virtual void CancelEvent()
        {
            if (Event.DaysTillEvent(DateTime.Now) <= 15) throw Errors["15Days"];
            Event.EventState = EVENT_STATE.CANCELLED;
            CancelledSuccessor.HandleEvent();
        }
        public abstract void HandleEvent();

        public abstract void ChangeEventState();
    }
}
