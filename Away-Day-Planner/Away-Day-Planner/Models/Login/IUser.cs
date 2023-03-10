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

namespace Away_Day_Planner.Models.Login
{
    public interface IUser
    {
        //getters and setters
        int userID { get; set; }
        String firstName { get; set; }
        String lastName { get; set; }
        String username { get; set; }
        String userEmail { get; set; }
        String userPassword { get; set; }
        byte[] userSalt { get; set; }

    }

}
