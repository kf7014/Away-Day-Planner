using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;
using Away_Day_Planner.Models.EventBooker;
using Away_Day_Planner.Database;

namespace Away_Day_Planner.Models.EventBooker
{
    public class EventModel : IEventModel
    {
        DatabaseAbstraction databaseAbstraction = new DatabaseAbstraction();
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

            //facilitatorTeams = new List<FacilitatorTeam>();
            //eventList = new List<Event>();

            //Populate dummy data        
            //eventList.Add(new Event());

            //eventList[0].activitiesList.Add(new Activity(0, "Test Activity", "Meal", 10, true, false, facilitatorTeams));
            
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

        public ActivityTemplate[] getActivityTemplates()
        {
            ActivityTemplate[] activityTemplates = databaseAbstraction.getActivityTemplates();
            return activityTemplates;
        }

        public RewardTemplate[] getRewardTemplates()
        {
            RewardTemplate[] rewardTemplates = databaseAbstraction.getRewardTemplates();
            return rewardTemplates;
        }

        public AdditionTemplate[] getAdditionTemplates()
        {
            AdditionTemplate[] additionTemplates = databaseAbstraction.getAdditionTemplates();
            return additionTemplates;
        }

        public ActivityTemplate getActivityTemplate(int activityId)
        {
            ActivityTemplate activityTemplate = databaseAbstraction.getActivityTemplate(activityId);
            return activityTemplate;
        }
        public RewardTemplate getRewardTemplate(int rewardId)
        {
            RewardTemplate rewardTemplate = databaseAbstraction.getRewardTemplate(rewardId);
            return rewardTemplate;
        }
        public AdditionTemplate getAdditionTemplate(int additionId)
        {
            AdditionTemplate additionTemplate = databaseAbstraction.getAdditionTemplate(additionId);
            return additionTemplate;
        }

        public void addNewEvent()
        {
            databaseAbstraction.addNewEvent();
        }

        public void addNewActivity(String name, Decimal price, bool facilitatorRequired, int eventFK)
        {
            databaseAbstraction.addNewActivity(name, price, facilitatorRequired, eventFK);
        }

        public void addNewReward(String name, Decimal price, int activityFK)
        {
            databaseAbstraction.addNewReward(name, price, activityFK);
        }

        public void addNewAddition(String name, Decimal price, int activityFK)
        {
            databaseAbstraction.addNewAddition(name, price, activityFK);
        }

        public Event[] getAllEvents()
        {
            Event[] events = databaseAbstraction.getAllEvents();
            return events;
        }

        public int getCurrentEventId()
        {
            Event[] events = getAllEvents();
            Event currentEvent = events[0];
            for (int i = 0; i < events.Length; i++)
            {
                if (events[i].id > currentEvent.id)
                {
                    currentEvent = events[i];
                }
            }

            return currentEvent.id;
        }
    }
}
