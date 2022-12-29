using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.ClientDepartment
{
    public interface IDepartment
    {
        int id { get; set; }
        String name { get; set; }
        Client Client { get; set; }
        int ClientFK { get; set; }
    }
}
