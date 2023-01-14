using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            Tuple<DbSet<Client>,DbContext> result = databaseInterface.GetAll<Client>().ToTuple();
            Client[] clients = result.Item1.ToArray();
            databaseInterface.DisposeContext(result.Item2);
            return clients;
        }

        public Client getClient(int clientId)
        {
            Tuple<Client,DbContext> result = databaseInterface.Get<Client>(clientId).ToTuple();
            Client client = result.Item1;
            databaseInterface.DisposeContext(result.Item2);
            return client;
        }
    }
}
