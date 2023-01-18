using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;
using Away_Day_Planner.Models.ClientDepartment;
using Away_Day_Planner.Models.EventBooker;

namespace Away_Day_Planner.Presenters
{
    public class EventBookerPresenter
    {
        private IEventBookerView eventBookerView;
        private IEventModel eventModel;
        private IClientModel clientModel;

        public EventBookerPresenter(IEventBookerView eventBookerView, IEventModel eventModel, IClientModel clientModel)
        {
            this.eventModel = eventModel;
            this.clientModel = clientModel;
            this.eventBookerView = eventBookerView;
            eventBookerView.register(this);
            populateScreen();
        }

        private void populateScreen()
        {
            //Customise event form title to match client and department
            setTitle();

            ////Populate activityList box
            //Currently uses hardcoded event ID, NEEDS CHANGING
            //IActivity[] activityList = eventModel.getEventActivityList(0);
            //String[] activityListNames = new string[activityList.Length];
            //for(int i=0; i<activityList.Length; i++)
            //{
            //    activityListNames[i] = activityList[i].name;
            //}

            //Sets activityList datasource in view
            //eventBookerView.setActivityList(activityListNames);

            //TODO
            setActivityList();
        }

        //Customise event form title to match client and department
        private void setTitle()
        {
            int clientId = eventModel.clientId;
            int departmentId = eventModel.departmentId;

            
            Client client = clientModel.getClient(clientId + 1);
            IDepartment[] departments = clientModel.getClientDepartments(clientId + 1);

            Console.WriteLine("Test: " + eventModel.departmentId);

            Department department = (Department)departments[eventModel.departmentId];

            eventBookerView.pageTitle = "Booking event for " + client.name + " and Department " + department.name;
        }

        private void setActivityList()
        {
            Event[] events = eventModel.getAllEvents();
            Event currentEvent = events[0];
            for(int i=0; i<events.Length; i++)
            {
                if(events[i].id > currentEvent.id)
                {
                    currentEvent = events[i];
                }
            }

            Console.WriteLine("Current Event is " + currentEvent.id);

            IActivity[] eventActivities = currentEvent.activitiesList.ToArray();
            String[] activityNames = new string[currentEvent.activitiesList.Count];
            for(int i=0; i < eventActivities.Length; i++)
            {
                String activityName = eventActivities[i].name;
                activityNames[i] = activityName;   
            }
            eventBookerView.setActivityList(activityNames);



        }
    }
}
