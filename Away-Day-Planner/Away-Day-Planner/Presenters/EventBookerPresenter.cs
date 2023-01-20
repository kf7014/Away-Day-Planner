﻿using System;
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

                for(int j=1; j<activityAdditions.Length; j++)
                {
                    totalPrice += activityAdditions[i].price;
                }

                for (int j=1; j < activityRewards.Length; j++)
                {
                    totalPrice += activityRewards[i].price;
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

            //TODO: IF FACILITATOR IS REQUIRED ON AN ACTIVITY
            IDate[] bookedFacilitatorDates = eventModel.getAllBookedFacilitatorTeamDates();

            //If Client is 2 hours away or closer check if facilitator teams are booked on that day
            if (clientDistance <= 2)
            {
                Console.WriteLine("bookedFacilitatorDates[0].dateTime: " + bookedFacilitatorDates[0].dateTime);
                Console.WriteLine(selectedDate);
                for(int i=0; i< bookedFacilitatorDates.Length; i++)
                {
                    if (bookedFacilitatorDates[i].dateTime.Date == selectedDate.Date)
                    {
                        dateAlreadyBooked = true;
                        Console.WriteLine("Facilitators unavailable that day");
                    }
                }
                //If client is further away than 2 hours check if facilitator is booked on after due to travel
            } else if (clientDistance > 2)
            {
                for (int i = 0; i < bookedFacilitatorDates.Length; i++)
                {                  
                    if (selectedDate.Date == bookedFacilitatorDates[i].dateTime.Date || selectedDateNextDay.Date == bookedFacilitatorDates[i].dateTime.Date)
                    {
                        dateAlreadyBooked = true;
                        Console.WriteLine("Facilitators unavailable");
                    }
                }
            }
        }
    }
}
