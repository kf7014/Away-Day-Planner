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

            Department department = (Department)departments[eventModel.departmentId];

            eventBookerView.pageTitle = "Booking event for " + client.name + " and Department " + department.name;
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
    }
}
