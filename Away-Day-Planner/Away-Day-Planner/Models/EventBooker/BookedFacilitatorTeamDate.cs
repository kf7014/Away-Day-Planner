/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009505
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
    public class BookedFacilitatorTeamDate : IDate
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

        public virtual FacilitatorTeam FacilitatorTeam { get; set; }
        [ForeignKey("FacilitatorTeam")]
        public int FacilitatorTeamFK { get; set; }
    }
}
