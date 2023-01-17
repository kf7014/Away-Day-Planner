using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.EventChain.Handlers
{
    public interface IHandler
    {
        void SetSuccessor(IHandler h);
        void HandleEvent();
        void CancelEvent();
        void ChangeEventState();
    }
}
