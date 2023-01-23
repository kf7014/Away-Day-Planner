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
    public class FacilitatorTeam
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

        private ICollection<IPerson> FacilitatorsList;
        public ICollection<IPerson> facilitatorsList
        {
            get { return FacilitatorsList; }
            set { FacilitatorsList = value; }
        }

        private ICollection<IDate> BookedDays;
        public ICollection<IDate> bookedDays
        {
            get { return BookedDays; }
            set { BookedDays = value; }
        }
    }
}
