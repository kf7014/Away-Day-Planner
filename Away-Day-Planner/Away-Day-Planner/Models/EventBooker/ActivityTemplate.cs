using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Away_Day_Planner.Models.EventBooker
{
    public class ActivityTemplate : IActivityTemplate
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

        private String Type;
        [Required, MinLength(2), MaxLength(50)]
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
    }
}
