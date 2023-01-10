using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Away_Day_Planner.Handler
{
    public enum EventState 
    {
        Preliminary,
        Confirmed,
        Archived,
        Cancelled
    }
    public enum PaymentState
    {
        Pending,
        Taken
    }
    public enum EventOptions
    {

    }
    internal interface IEvent
    {
        int GetCharge();
    }
}
