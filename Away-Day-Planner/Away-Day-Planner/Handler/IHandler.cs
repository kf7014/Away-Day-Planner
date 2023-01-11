using Away_Day_Planner.Models.EventBooker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Handler
{
    internal interface IHandler
    {
        void SetSuccessor(Handler s);
        void HandleEvent(Event e);
    }
}
