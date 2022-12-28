using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.EventBooker
{
    public interface IActivity
    {
        int id { get; }
        String name { get; set; }
        String type { get; set; }
        Decimal price { get; set; }
        Boolean facilitatorRequired { get; set; }
        Boolean isBooked { get; set; }
        ICollection<FacilitatorTeam> allocatedFacilitatorTeams { get; set; }



    }
}
