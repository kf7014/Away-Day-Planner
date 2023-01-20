using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.CORChain.Handlers
{
    public interface IHandler
    {
        IHandler Successor { get; }
        void SetSuccessor(IHandler h);
        void HandleEvent(IEvent e);
    }
}
