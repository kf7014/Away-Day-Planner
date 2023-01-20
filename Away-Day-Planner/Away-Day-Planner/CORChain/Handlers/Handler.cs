using Away_Day_Planner.Utilities;
using System;
using System.Collections.Generic;

namespace Away_Day_Planner.CORChain.Handlers
{
    public abstract class Handler : IHandler
    {
        public readonly Dictionary<string, Exception> Errors = ErrorList.EventErrors;
        public IHandler Successor { get; set; }

        public virtual void SetSuccessor(IHandler h) 
        { 
            Successor = h;
        }
        public abstract void HandleEvent(IEvent Event);
    }
}
