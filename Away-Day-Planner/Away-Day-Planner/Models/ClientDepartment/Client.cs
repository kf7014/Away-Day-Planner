using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Away_Day_Planner.Models.ClientDepartment
{
    public class Client
    {
        
        private int Id;
        [Key]
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }


        private ICollection<IDepartment> Departments;
        public virtual ICollection<IDepartment> departments
        {
            get { return Departments; }
            set { Departments = value; }
        }

        
        private bool HasClientDispute;
        [Required]
        public bool hasClientDispute
        {
            get { return HasClientDispute; }
            set { HasClientDispute = value; }
        }

        
        private int NoOfHoursAway;
        [Required]
        public int noOfHoursAway
        {
            get { return NoOfHoursAway; }
            set { NoOfHoursAway = value; }
        }

        
        private String Name;
        [Required, MinLength(2), MaxLength(50)]
        public String name
        {
            get { return Name; }
            set { Name = value; }
        }

        public Client(int id, string name, int noOfHoursAway, bool hasClientDispute)
        {
            Id = id;
            Name = name;
            NoOfHoursAway = noOfHoursAway;
            HasClientDispute = hasClientDispute;
            Departments = new List<IDepartment>();
        }
    }
}
