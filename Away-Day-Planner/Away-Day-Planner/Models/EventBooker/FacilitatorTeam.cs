using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.EventBooker
{
    public class FacilitatorTeam
    {
        private int Id;
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        private ICollection<IPerson> FacilitatorsList;
        public ICollection<IPerson> facilitatorsList
        {
            get { return FacilitatorsList; }
            set { FacilitatorsList = value; }
        }

        private ICollection<DateTime> BookedDays;
        public ICollection<DateTime> bookedDays
        {
            get { return BookedDays; }
            set { BookedDays = value; }
        }
    }
}
