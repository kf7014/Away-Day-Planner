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

        private int ClientId;
        public int clientId
        {
            get { return ClientId;  }
            set { ClientId = value; }           
        }

        private int DepartmentId;
        public int departmentId
        {
            get { return DepartmentId; }
            set { DepartmentId = value; }
        }

        public EventModel()
        {
            //TODO: Demo code to be replaced by db stuff

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

        //Sets clientId and departmentId to that of parent which event is being set to
        public void setParents(int clientId, int departmentId)
        {
            this.clientId = clientId;
            this.departmentId = departmentId;
        }
    }
}
