using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Models.ClientDepartment;

namespace Away_Day_Planner.Database
{
    public class DatabaseAbstraction
    {
        IDatabaseInterface databaseInterface = new DatabaseInterface();

        public DatabaseAbstraction()
        {
            
        }

        public void addNewClient(String clientName, int noOfHoursAway, bool hasClientDispute)
        {
            //TODO: Replace placeholder ID when new method added to Database Interface
            Client newClient = new Client(10, clientName, noOfHoursAway, hasClientDispute);
            databaseInterface.Add(newClient); 
        }

        public void addNewDepartment(String name, Client client)
        {
            int clientFK = client.id;

            Department newDepartment = new Department(name, client, clientFK);
            databaseInterface.Add(newDepartment);
        }

        public Client[] getAllClients()
        {
            IResults results = databaseInterface.GetAll(typeof(Client));
            ArrayList resultsArrayList = (ArrayList)results.GetList();

            List<Client> resultsList = new List<Client>(resultsArrayList.Count);
            foreach (Client client in resultsArrayList) resultsList.Add(client);

            return resultsList.ToArray();
       }
    }
}
