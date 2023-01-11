using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Database;

namespace Away_Day_Planner.Models.ClientDepartment
{
    public class ClientModel : IClientModel    
    {
        DatabaseAbstraction databaseAbstraction = new DatabaseAbstraction();
        List<Client> clientList; 
        public ClientModel()
        {
            //Create dummy database data at runtime
            //TODO: This could be moved to program.cs, especially if theres a lot of classes doing it
            databaseAbstraction.addNewClient("Kieran New Method", 1, false);
            databaseAbstraction.addNewClient("Sandra New Method", 1, true);
            //TODO: Change dummy FK when autoincrement stuff added to DatabaseInterface
            databaseAbstraction.addNewDepartment("New DB Test Department", 10);
            
            
            clientList = new List<Client>();

            //clientList.Add(new Client(0, "Kieran", 1, false));
            //clientList.Add(new Client(1, "Sandra", 2, false));

            ////Add data to department dummy
            //clientList[0].departments.Add(new Department("Test Department"));
            //clientList[1].departments.Add(new Department("Sandras Department"));


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
            Client[] clientsList = databaseAbstraction.getAllClients();
            return clientsList;
        }


        public void addNewClient(String clientName, int noOfHoursAway, bool hasClientDispute)
        {
            databaseAbstraction.addNewClient(clientName, noOfHoursAway, hasClientDispute);
        }
    }
}
