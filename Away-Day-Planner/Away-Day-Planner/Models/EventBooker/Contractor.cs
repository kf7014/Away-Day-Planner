using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Away_Day_Planner.Models.EventBooker
{
    public class Contractor
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

        private ICollection<IActivity> Activities;
        public ICollection<IActivity> activities
        {
            get { return Activities; }
            set { Activities = value; }
        }

        public Contractor(int id, string name, ICollection<IActivity> activities)
        {
            Id = id;
            Name = name;
            Activities = activities;
        }
    }
}
