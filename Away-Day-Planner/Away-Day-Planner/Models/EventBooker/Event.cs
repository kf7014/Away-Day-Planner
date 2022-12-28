using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.EventBooker
{
    public class Event
    {
        private int Id;
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        private ICollection<IActivity> ActivitiesList;
        public ICollection<IActivity> activitiesList
        {
            get { return ActivitiesList; }
            set { ActivitiesList = value; }
        }

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

        private Boolean IsBooked;
        public Boolean isBooked
        {
            get { return IsBooked; }
            set { IsBooked = value; }
        }
    }
}
