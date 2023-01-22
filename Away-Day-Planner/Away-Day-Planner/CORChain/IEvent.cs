/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009595
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using Away_Day_Planner.CORChain.Handlers;
using Away_Day_Planner.Models.EventBooker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.CORChain
{
    public enum EVENT_STATE
    {
        BASE, PRELIMINARY, EVENT, PAYMENT, CANCELLED, ARCHIVED
    }
    public interface IEvent
    {
        EVENT_STATE EventState { get; set; }
        IDate bookingDate { get; set; }
        double DaysTillEvent(DateTime currentTime);
        decimal price { get; set; }
        ICollection<IActivity> activitiesList { get; set; }

    }
}
