/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009505
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
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
