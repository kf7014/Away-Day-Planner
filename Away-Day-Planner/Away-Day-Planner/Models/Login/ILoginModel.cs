using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.Login
{
    public interface ILoginModel
    {

        void addNewUser(String firstName, String lastName, String username, String userEmail, byte[] userPassword, String userRole);

    }
}
