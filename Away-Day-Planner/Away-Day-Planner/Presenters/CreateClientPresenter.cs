using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;
using Away_Day_Planner.Models.ClientDepartment;

namespace Away_Day_Planner.Presenters
{
    public class CreateClientPresenter
    {
        private ICreateClientView createClientView;
        private IClientModel clientModel;

        public CreateClientPresenter(ICreateClientView createClientView, IClientModel clientModel)
        {
            this.createClientView = createClientView;
            this.clientModel = clientModel;
            createClientView.register(this);
        }

        public void buttonAddClientClickEvent()
        {
            String clientName = createClientView.ClientName;
            int noOfHoursAway = Convert.ToInt32(createClientView.NumberOfHoursAway);
            bool hadClientDispute = createClientView.HadClientDispute;
            Console.WriteLine("Client would be added with following details: ");
            Console.WriteLine("Name: " + clientName);
            Console.WriteLine("No Of Hours Away: " + noOfHoursAway);
            Console.WriteLine("Had Client Dispute: " + hadClientDispute);

            clientModel.addNewClient(clientName, noOfHoursAway, hadClientDispute);
        }
    }
}
