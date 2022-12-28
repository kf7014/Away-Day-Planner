using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.EventBooker
{
    public interface IFacilitatorTeamModel
    {
        void addToSchedule(int facilitatorTeamId, ICollection<DateTime> date);
        void removeFromSchedule(int facilitatorTeamId, ICollection<DateTime> date);
    }
}
