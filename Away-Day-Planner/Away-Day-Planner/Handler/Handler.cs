using Away_Day_Planner.Models.EventBooker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Handler
{
    internal abstract class Handler : IHandler
    {
        protected Handler successor;

        public abstract void HandleEvent(Event e);

        public void SetSuccessor(Handler s)
        {
            successor = s;
        }
    }
}
