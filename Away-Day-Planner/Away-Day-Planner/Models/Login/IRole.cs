using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.Login
{
    public interface IRole
    {
        //getters and setters
        int roleID { get; set; }
        String staffRole { get; set; }

    }
}
