﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Away_Day_Planner.Models.EventBooker
{
    public class Event
    {
        private int Id;
        [Key]
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        //Needs linking up to Activity
        private ICollection<IActivity> ActivitiesList;
        public ICollection<IActivity> activitiesList
        {
            get { return ActivitiesList; }
            set { ActivitiesList = value; }
        }

        //Needs linking up to dates
        private ICollection<DateTime> AvailableDaysFlexibilityList;
        public ICollection<DateTime> availableDaysFlexibilityList
        {
            get { return AvailableDaysFlexibilityList; }
            set { AvailableDaysFlexibilityList = value; }
        }

        private int NoOfAttendees;
        public int noOfAttendees
        {
            get { return NoOfAttendees; }
            set { NoOfAttendees = value; }
        }

        [Required]
        private Boolean IsBooked;
        public Boolean isBooked
        {
            get { return IsBooked; }
            set { IsBooked = value; }
        }
    }
}
