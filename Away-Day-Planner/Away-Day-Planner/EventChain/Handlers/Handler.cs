using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.EventChain.Handlers
{
    internal abstract class Handler : IHandler
    {
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
            CancelledSuccessor.HandleEvent();
        }
        public abstract void HandleEvent();
    }
}
