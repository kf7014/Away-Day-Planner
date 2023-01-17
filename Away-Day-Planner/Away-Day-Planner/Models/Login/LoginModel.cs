using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Database;

namespace Away_Day_Planner.Models.Login
{
    public class LoginModel : ILoginModel
    {
        DatabaseAbstraction databaseAbstraction = new DatabaseAbstraction();
        public void addNewUser(string firstName, string lastName, string username, string userEmail, byte[] userPassword, string userRole)
        {
            databaseAbstraction.addNewUser(firstName, lastName, username, userEmail, userPassword, userRole);
        }
    }
}
