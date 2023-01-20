using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Away_Day_Planner.Models.EventBooker
{
    public class Activity : IActivity
    {
        private int Id;
        [Key]
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        private String Name;
        [Required, MinLength(2), MaxLength(50)]
        public String name
        {
            get { return Name; }
            set { Name = value; }
        }

        private Decimal Price;
        public Decimal price
        {
            get { return Price; }
            set { Price = value; }
        }

        [Required]
        private Boolean FacilitatorRequired;
        public Boolean facilitatorRequired
        {
            get { return FacilitatorRequired; }
            set { FacilitatorRequired = value; }
        }

        [Required]
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

        public virtual FacilitatorTeam FacilitatorTeam { get; set; }
        [ForeignKey("FacilitatorTeam")]
        public int FacilitatorTeamFK { get; set; }

        public virtual Event Event { get; set; }
        [ForeignKey("Event")]
        public int EventFK { get; set; }


        public Activity(String name, Decimal price, Boolean facilitatorRequired, int eventFK)
        {
            this.Name = name;
            this.Price = price;
            this.FacilitatorRequired = facilitatorRequired;
            this.IsBooked = false;
            this.EventFK = eventFK;
        }

        public Activity()
        {

        }
    }
}
