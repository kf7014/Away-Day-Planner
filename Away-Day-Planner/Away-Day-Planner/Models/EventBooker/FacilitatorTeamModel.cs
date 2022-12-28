using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.EventBooker
{
    public class FacilitatorTeamModel : IFacilitatorTeamModel
    {
        public void addToSchedule(int facilitatorTeamId, ICollection<DateTime> date)
        {
            throw new NotImplementedException();
        }

        public void removeFromSchedule(int facilitatorTeamId, ICollection<DateTime> date)
        {
            throw new NotImplementedException();
        }
    }
}
