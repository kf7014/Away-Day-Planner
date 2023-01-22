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
using Away_Day_Planner.Database;

namespace Away_Day_Planner.Models.Login
{
    public class LoginRegistrationModel : ILoginRegistrationModel
    {
        DatabaseAbstraction databaseAbstraction = new DatabaseAbstraction();
        public void addNewUser(string firstName, string lastName, string username, string userEmail, string userPassword, byte[] userSalt)
        {
            databaseAbstraction.addNewUser(firstName, lastName, username, userEmail, userPassword, userSalt);
          
        }

        public User getUserFromLogin(string username,  string userPassword)
        {
           User[] users = databaseAbstraction.getAllUsers();
            for (int x=0 ; x < users.Length ; x++)
            {
                if (users[x].username == username && users[x].userPassword == userPassword)
                {
                    return users[x];
                }
            }
            return null;
        }

        public User[] getAllUsers()
        {
            User[] users = databaseAbstraction.getAllUsers();
            return users;
        }

    }
    
}
