using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.EventBooker
{
    public class Activity : IActivity
    {
        private int Id;
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        private String Name;
        public String name
        {
            get { return Name; }
            set { Name = value; }
        }

        private String Type;
        public String type
        {
            get { return Type; }
            set { Type = value; }
        }

        private Decimal Price;
        public Decimal price
        {
            get { return Price; }
            set { Price = value; }
        }

        private Boolean FacilitatorRequired;
        public Boolean facilitatorRequired
        {
            get { return FacilitatorRequired; }
            set { FacilitatorRequired = value; }
        }

        private Boolean IsBooked;
        public Boolean isBooked
        {
            get { return IsBooked; }
            set { IsBooked = value; }
        }

        private ICollection<FacilitatorTeam> AllocatedFacilitatorTeams;
        public ICollection<FacilitatorTeam> allocatedFacilitatorTeams
        {
            get { return AllocatedFacilitatorTeams; }
            set { AllocatedFacilitatorTeams = value; }
        }
    }
}
