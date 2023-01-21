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
            //Populate client distance label
            setDistance();
            //Populate activity list for event
            setActivityList();
            //Populate total price field for each activity within the event
            setPrice();
        }

        //Customise event form title to match client and department
        private void setTitle()
        {
            int clientId = eventModel.clientId;
            int departmentId = eventModel.departmentId;

            
            Client client = clientModel.getClient(clientId + 1);
            IDepartment[] departments = clientModel.getClientDepartments(clientId + 1);

            Department department = (Department)departments[eventModel.departmentId];

            eventBookerView.pageTitle = "Booking event for " + client.name + " and Department " + department.name;
        }

        private void setDistance()
        {
            int clientId = eventModel.clientId;
            Client client = clientModel.getClient(clientId + 1);
            int clientDistance = client.noOfHoursAway;
            eventBookerView.clientDistance = clientDistance.ToString();
        }

        private void setPrice()
        {
            int clientId = eventModel.clientId;
            int eventId = eventModel.getCurrentEventId();
            IActivity[] eventActivities = eventModel.getEventActivityList(eventId);

            Decimal totalPrice = 0;

            for(int i=0; i<eventActivities.Length; i++)
            {
                
                IAddition[] activityAdditions = eventModel.getActivityAdditions(eventActivities[i].id);
                IReward[] activityRewards = eventModel.getActivityRewards(eventActivities[i].id);

                totalPrice += eventActivities[i].price;

                foreach (IAddition addition in activityAdditions)
                {
                    totalPrice += addition.price;
                }
                foreach (IReward reward in activityRewards)
                {
                    totalPrice += reward.price;
                }
            }

            eventBookerView.totalPrice = totalPrice.ToString();
        }

        private void setActivityList()
        {
            int currentEventId = eventModel.getCurrentEventId();
            IActivity[] activities = eventModel.getEventActivityList(currentEventId);
            String[] activityNames = new string[activities.Length];
            for(int i=0; i < activities.Length; i++)
            {
                String activityName = activities[i].name;
                activityNames[i] = activityName;
            }
            eventBookerView.setActivityList(activityNames);
        }

        public void buttonAddActivityEvent()
        {
            populateScreen();
        }

        public void buttonConfirmBookingEvent()
        {
            bool chosenDateAvailable = checkDateAvailability();
            if (chosenDateAvailable)
            {
                //TODO: Update event
                Console.WriteLine("Update Event with following info:");
                Console.WriteLine("Booking day: " + eventBookerView.selectedDate.Date);
                Console.WriteLine("Price: " + eventBookerView.totalPrice);
                Console.WriteLine("Number of attendees: " + eventBookerView.noOfAttendees);
                Console.WriteLine("Is Booked: True");

                int currentEventId = eventModel.getCurrentEventId();
                int eventNoOfAttendees = eventBookerView.noOfAttendees;
                Date eventDate = new Date(eventBookerView.selectedDate.Date);
                Decimal eventPrice = Decimal.Parse(eventBookerView.totalPrice);

                Event newEvent = new Event(eventNoOfAttendees, eventDate, eventPrice);

                //TODO: Update Event
                //eventModel.updateEvent(currentEventId, newEvent);
                //Console.WriteLine("Event should be added");
            }
        }


        public bool checkDateAvailability()
        {
            ////Get all BookedFacilitatorTeamDates, and check if selectedDate matches if a facilitator is required on any activity
            DateTime selectedDate = eventBookerView.selectedDate;
            //Get day after selected date
            DateTime selectedDateNextDay = selectedDate;
            selectedDateNextDay = selectedDate.AddDays(1);

            bool dateAlreadyBooked = false;

            //Get client info
            int clientId = eventModel.clientId;
            Client client = clientModel.getClient(clientId + 1);
            int clientDistance = client.noOfHoursAway;

            //IF FACILITATOR IS REQUIRED ON AN ACTIVITY
            if (checkFacilitatorNeeded(eventModel.getCurrentEventId()))
            {
                IDate[] bookedFacilitatorDates = eventModel.getAllBookedFacilitatorTeamDates();

                //If Client is 2 hours away or closer check if facilitator teams are booked on that day
                if (clientDistance <= 2)
                {
                    for (int i = 0; i < bookedFacilitatorDates.Length; i++)
                    {
                        if (bookedFacilitatorDates[i].dateTime.Date == selectedDate.Date)
                        {
                            Console.WriteLine("Facilitators unavailable that day");
                            eventBookerView.ErrorDate = "Facilitators unavailable that day";
                            dateAlreadyBooked = true;                          
                        }
                    }
                }//If client is further away than 2 hours check if facilitator is booked on after due to travel
                else if (clientDistance > 2)
                {
                    for (int i = 0; i < bookedFacilitatorDates.Length; i++)
                    {
                        if (selectedDate.Date == bookedFacilitatorDates[i].dateTime.Date || selectedDateNextDay.Date == bookedFacilitatorDates[i].dateTime.Date)
                        {
                            dateAlreadyBooked = true;
                            Console.WriteLine("Facilitators unavailable");
                            eventBookerView.ErrorDate = "Facilitators unavailable that day";
                        }
                    }
                }

                //Returns true if date is available
                if (dateAlreadyBooked)
                {
                    return false;
                }
                else
                {
                    eventBookerView.ErrorDate = "";
                    return true;
                }
            } else
            {
                //Facilitator not required on any activities
                Console.WriteLine("Facilitator not needed");
                return true;
            }   
        }

        public bool checkFacilitatorNeeded(int eventId)
        {
            bool facilitatorNeeded = false;

            IActivity[] activitiesList = eventModel.getEventActivityList(eventId);
            foreach(IActivity activity in activitiesList)
            {
                if(activity.facilitatorRequired == true)
                {
                    facilitatorNeeded = true;
                }
            }

            if(facilitatorNeeded == true)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
