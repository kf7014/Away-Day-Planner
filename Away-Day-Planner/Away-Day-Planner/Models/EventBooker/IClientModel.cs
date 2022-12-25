using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.EventBooker
{
    public interface IClientModel
    {
        Client[] getClientList();
        IDepartment[] getClientDepartments(int clientId);
    }
}
