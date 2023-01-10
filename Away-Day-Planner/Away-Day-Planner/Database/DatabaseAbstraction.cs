using System;
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

        public void addNewDepartment(String name, int clientFK)
        {
            Department newDepartment = new Department(name, clientFK);
            databaseInterface.Add(newDepartment);
        }
    }
}
