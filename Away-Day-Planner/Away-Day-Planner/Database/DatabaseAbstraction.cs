using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Models.ClientDepartment;
using Away_Day_Planner.Models.EventBooker;

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
            Client newClient = new Client(clientName, noOfHoursAway, hasClientDispute);
            Console.WriteLine("Client supposed to be added");
            databaseInterface.Add(newClient); 
        }

        public void addNewDepartment(String name, Client client)
        {
            int clientFK = client.id;

            Department newDepartment = new Department(name, clientFK);
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

        public Department[] getClientDepartments(int clientId)
        {
            Tuple<DbSet<Department>, DbContext> result = databaseInterface.GetAll<Department>().ToTuple();
            Department[] departments = result.Item1.ToArray();
            List<Department> clientDepartments = new List<Department>();
            foreach(Department department in departments)
            {
                if (department.ClientFK == clientId)
                {
                    clientDepartments.Add(department);
                }
            }

            return clientDepartments.ToArray();
        }

        public ActivityTemplate[] getActivityTemplates()
        {
            Tuple<DbSet<ActivityTemplate>, DbContext> result = databaseInterface.GetAll<ActivityTemplate>().ToTuple();
            ActivityTemplate[] activityTemplates = result.Item1.ToArray();
            databaseInterface.DisposeContext(result.Item2);
            return activityTemplates;
        }

        public RewardTemplate[] getRewardTemplates()
        {
            Tuple<DbSet<RewardTemplate>, DbContext> result = databaseInterface.GetAll<RewardTemplate>().ToTuple();
            RewardTemplate[] rewardTemplates = result.Item1.ToArray();
            databaseInterface.DisposeContext(result.Item2);
            return rewardTemplates;
        }
    }
}
