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

namespace Away_Day_Planner.Models.EventBooker
{
    public interface IActivity
    {
        int id { get; }
        String name { get; set; }
        Decimal price { get; set; }
        Boolean facilitatorRequired { get; set; }
        Boolean isBooked { get; set; }
        int EventFK { get; set; }
        ICollection<FacilitatorTeam> allocatedFacilitatorTeams { get; set; }



    }
}
