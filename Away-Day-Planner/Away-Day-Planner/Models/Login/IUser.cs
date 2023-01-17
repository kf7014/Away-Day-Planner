using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.Login
{
    public interface IUser
    {
        int userID { get; set; }
        String firstName { get; set; }
        String lastName { get; set; }
        String username { get; set; }
        String userEmail { get; set; }
        String userRole{ get; set; }

}

}
