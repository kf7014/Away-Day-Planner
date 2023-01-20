using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.CORChain.Handlers
{
    public class CancelledFeeChain
    {
        public static Handler CreateSuccessorChain()
        {
            DayHandler60 dh60 = new DayHandler60();
            DayHandler30 dh30 = new DayHandler30();
            DayHandler15 dh15 = new DayHandler15();

            dh60.SetSuccessor(dh30);
            dh30.SetSuccessor(dh15);
            return dh60;

        }
        public static void ProcessEvent(IEvent _event)
        {
            Handler _base = CreateSuccessorChain();
            _base.HandleEvent(_event);
        }
    }
}
