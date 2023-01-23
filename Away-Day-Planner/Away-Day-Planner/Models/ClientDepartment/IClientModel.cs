/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009505
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.ClientDepartment
{
    public interface IClientModel
    {
        Client[] getClientList();
        IDepartment[] getClientDepartments(int clientId);
        void addNewClient(String clientName, int noOfHoursAway, bool hasClientDispute);
        void addNewDepartment(String departmentName, Client client);
        Client getClient(int clientId);
    }
}
