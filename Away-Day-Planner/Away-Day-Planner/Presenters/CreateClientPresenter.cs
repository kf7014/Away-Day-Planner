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
            //TODO: Complete functionality for buttonAddClientClickEvent

            String clientName = createClientView.ClientName;
            //clientModel.addNewClient();
            Console.WriteLine("Client would be added");
        }
    }
}
