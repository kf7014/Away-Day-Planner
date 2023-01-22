/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009595
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Away_Day_Planner.Models.EventBooker
{
    public class Date : IDate
    {
        private int Id;
        [Key]
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        private DateTime DateTime;
        public DateTime dateTime
        {
            get { return DateTime; }
            set { DateTime = value; }
        }

        public virtual Event Event { get; set; }
        [ForeignKey("Event")]
        public int EventFK { get; set; }

        public Date(DateTime dateTime, int eventFK)
        {
            this.dateTime = dateTime;
            this.EventFK = eventFK;
        }
    }
}
