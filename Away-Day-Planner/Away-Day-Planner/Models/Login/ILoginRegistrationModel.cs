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
    public interface ILoginRegistrationModel
    {

        //adding new user
        void addNewUser(String firstName, String lastName, String username, String userEmail, String userPassword, byte[] userSalt);
        User getUserFromLogin(string username, string userPassword);
        User[] getAllUsers();
    }
}
