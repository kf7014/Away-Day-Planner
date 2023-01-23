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

        //Display the distance of the client the event is being booked for on the form
        private void setDistance()
        {
            int clientId = eventModel.clientId;
            Client client = clientModel.getClient(clientId + 1);
            int clientDistance = client.noOfHoursAway;
            eventBookerView.clientDistance = clientDistance.ToString();
        }

        //Display the price of all activities within the event on the form
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

        //Updates UI on buttonAddActivity is pressed to reflect changes
        public void buttonAddActivityEvent()
        {
            populateScreen();
        }

        //Runs when confirm booking button is pressed
        public void buttonConfirmBookingEvent()
        {
            bool chosenDateAvailable = checkDateAvailability();
            if (chosenDateAvailable)
            {
                int currentEventId = eventModel.getCurrentEventId();
                int eventNoOfAttendees = eventBookerView.noOfAttendees;
                Decimal eventPrice = Decimal.Parse(eventBookerView.totalPrice);

                if (eventModel.getEventActivityList(currentEventId).Length != 0)
                {
                    Event newEvent = new Event(eventNoOfAttendees, eventPrice);


                    //Update Event 
                    Event eventToUpdate = eventModel.getEvent(currentEventId);
                    eventModel.updateEvent(eventToUpdate, "price", eventPrice);
                    eventModel.updateEvent(eventToUpdate, "noOfAttendees", eventNoOfAttendees);
                    eventModel.updateEvent(eventToUpdate, "isBooked", true);

                    int newEventId = eventModel.getCurrentEventId();
                    eventModel.addNewDate(eventBookerView.selectedDate.Date, newEventId);

                    eventBookerView.SuccessFailMessage = "Event successfully booked!";
                }
                else
                {
                    eventBookerView.SuccessFailMessage = "Activities need to be added";
                }
            }
        }


        public bool checkDateAvailability()
        {
            ////Get all BookedFacilitatorTeamDates, and check if selectedDate matches if a facilitator is required on any activity
            DateTime selectedDate = eventBookerView.selectedDate;
            //Get day after selected date
            DateTime selectedDateNextDay = selectedDate;
            selectedDateNextDay = selectedDate.AddDays(1);

            //Set initial validation failure flag to false
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
                return true;
            }   
        }

        //Check if an event has an activity that will require facilitators to be booked
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
