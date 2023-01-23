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
            Activity[] activities = databaseAbstraction.getAllActivities();
            List<Activity> currentActivities = new List<Activity>();

            int currentEvent = getCurrentEventId();

            for(int i=0; i<activities.Length; i++)
            {
                if(activities[i].EventFK == currentEvent)
                {
                    currentActivities.Add(activities[i]);
                }
            }

            IActivity[] currentActivitiesArray = currentActivities.ToArray();
            return currentActivitiesArray;

        }

        public Event getEvent(int eventId)
        {
            return databaseAbstraction.getEvent(eventId);
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

        public Reward[] getActivityRewards(int activityId)
        {
            Reward[] activityRewards = databaseAbstraction.getActivityRewards(activityId);
            return activityRewards;
        }

        public Addition[] getActivityAdditions(int activityId)
        {
            Addition[] activityAdditions = databaseAbstraction.getActivityAdditions(activityId);
            return activityAdditions;
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

        public IActivity[] getAllActivities()
        {
            IActivity[] activities = databaseAbstraction.getAllActivities();
            return activities;
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

        public int getCurrentActivityId()
        {
            IActivity[] activities = getAllActivities();
            IActivity currentActivity = activities[0];
            for (int i = 0; i < activities.Length; i++)
            {
                if (activities[i].id > currentActivity.id)
                {
                    currentActivity = activities[i];
                }
            }

            return currentActivity.id;
        }

        public Date[] getAllStoredDates()
        {
            Date[] storedDates = databaseAbstraction.getAllStoredDates();
            return storedDates;
        }

        public BookedFacilitatorTeamDate[] getAllBookedFacilitatorTeamDates()
        {
            BookedFacilitatorTeamDate[] bookedFacilitatorTeamDates = databaseAbstraction.getBookedFacilitatorTeams();
            return bookedFacilitatorTeamDates;
        }

        public void updateEvent(Event _event, String field, object value)
        {
            databaseAbstraction.updateEvent(_event, field, value);
        }
        public void pdfPopulation()
        {
            
        }

        public void addNewDate(DateTime eventDate, int newEventId)
        {
            databaseAbstraction.addNewDate(eventDate, newEventId);
        }

    }
}
