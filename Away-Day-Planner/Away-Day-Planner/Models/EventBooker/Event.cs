using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Away_Day_Planner.EventChain;
using Away_Day_Planner.EventChain.Handlers;

namespace Away_Day_Planner.Models.EventBooker
{
    public class Event : IEvent
    {
        public EVENT_STATE EventState { get; set; }

        private int Id;
        [Key]
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

        private IDate BookingDate;
        public IDate bookingDate
        {
            get { return BookingDate; }
            set { BookingDate = value; }
        }

        private Decimal Price;
        public Decimal price
        {
            get { return Price; }
            set { Price = value; }
        }

        private ICollection<IDate> AvailableDaysFlexibilityList;
        public ICollection<IDate> availableDaysFlexibilityList
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

        public Event(int id)
        {
            Id = id;
            ActivitiesList = new List<IActivity>();
        }
    }
}
