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
            clientList.Add(new Client("Kieran", 1, false));
            clientList.Add(new Client("Sandra", 2, false));
        }

        public Client[] getClientList()
        {
            return clientList.ToArray();
        }
    }
}
