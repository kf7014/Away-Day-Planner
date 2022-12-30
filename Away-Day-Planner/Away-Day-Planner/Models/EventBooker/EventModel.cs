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
        List<FacilitatorTeam> facilitatorTeams;
        List<Event> eventList;

        public EventModel()
        {
            //Demo code to be replaced by db stuff

            facilitatorTeams = new List<FacilitatorTeam>();
            eventList = new List<Event>();

            //Populate dummy data        
            eventList.Add(new Event(0));

            eventList[0].activitiesList.Add(new Activity(0, "Test Activity", "Meal", 10, true, false, facilitatorTeams));
            
        }

        //Get all activities for specified event
        public IActivity[] getEventActivityList(int eventId)
        {
            for(int i=0; i<eventList.Count; i++)
            {
                if(eventList[i].id == eventId)
                {
                    return eventList[i].activitiesList.ToArray();
                }
            }
            return null;
        }
    }
}
