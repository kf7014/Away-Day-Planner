using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.EventBooker
{
    public class ClientModel : IClientModel    
    {
        List<Client> clientList; 
        public ClientModel()
        {
            clientList = new List<Client>();
            clientList.Add(new Client(0, "Kieran", 1, false));
            clientList.Add(new Client(1, "Sandra", 2, false));

            //Add data to department dummy
            clientList[0].departments.Add(new Department("Test Department"));
            clientList[1].departments.Add(new Department("Sandras Department"));

        }

        public IDepartment[] getClientDepartments(int clientId)
        {
            for(int i=0; i<clientList.Count; i++)
            {
                if(clientList[i].id == clientId)
                {
                    return clientList[i].departments.ToArray();
                }
            }

            return null;
        }

        public Client[] getClientList()
        {
            return clientList.ToArray();
        }
    }
}
