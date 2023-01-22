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
using Away_Day_Planner.Models.EventBooker;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Away_Day_Planner.Models.EventBooker
{
    public class Facilitator : IPerson
    {
        private int Id;
        [Key]
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        private String FirstName;
        [Required, MinLength(2), MaxLength(50)]
        public String firstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        private String LastName;
        [Required, MinLength(2), MaxLength(50)]
        public String lastName
        {
            get { return LastName; }
            set { LastName = value; }
        }

        private String EmailAddress;
        [Required, MinLength(5), MaxLength(50)]
        public String emailAddress
        {
            get { return EmailAddress; }
            set { EmailAddress = value; }
        }

        
        public virtual FacilitatorTeam FacilitatorTeam { get; set; }
        [ForeignKey("FacilitatorTeam")]
        public int FacilitatorTeamFK { get; set; }
    }
}
