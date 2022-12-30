using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Away_Day_Planner.Models.EventBooker
{
    public class EventFlexibilityDate : IDate
    {
        private int Id;
        [Key]
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        [Required]
        private DateTime DateTime;
        public DateTime dateTime
        {
            get { return DateTime; }
            set { DateTime = value; }
        }

        public virtual Event Event { get; set; }
        [ForeignKey("Event")]
        public int EventFK { get; set; }
    }
}
