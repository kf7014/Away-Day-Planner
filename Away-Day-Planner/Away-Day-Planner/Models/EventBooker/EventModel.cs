using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.EventBooker
{
    public class EventModel : IEventModel
    {
        //Demo code to be replaced by db stuff
        List<IActivity> activityList;
        List<IDate> eventFlexibilityDates;
        List<FacilitatorTeam> facilitatorTeams;
        List<Event> eventList;

        public EventModel()
        {
            //Demo code to be replaced by db stuff
            activityList = new List<IActivity>();
            eventFlexibilityDates = new List<IDate>();
            facilitatorTeams = new List<FacilitatorTeam>();
            eventList = new List<Event>();

            //Populate dummy data
            activityList.Add(new Activity(0, "Test Activity", "Meal", 10, true, false, facilitatorTeams));
            eventList.Add(new Event(0,activityList,eventFlexibilityDates,10,false));
        }
    }
}
