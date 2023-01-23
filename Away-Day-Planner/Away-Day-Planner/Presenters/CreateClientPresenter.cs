/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009595
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
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

        //Runs when add client button is pressed
        public bool buttonAddClientClickEvent()
        {
            String clientName = createClientView.ClientName;
            int noOfHoursAway = Convert.ToInt32(createClientView.NumberOfHoursAway);
            bool hadClientDispute = createClientView.HadClientDispute;

            bool validationErrors = false;           

            //Client name validation
            if(clientName.Length < 2)
            {
                createClientView.ErrorMessageName = "Client name must be longer than 2 characters";
                validationErrors = true;
            } else if(clientName.Length > 50)
            {
                createClientView.ErrorMessageName = "Client name must be shorter than 50 characters";
                validationErrors = true;
            } else if(clientName == null)
            {
                createClientView.ErrorMessageName = "Client name cannot be null";
                validationErrors = true;
            }

            //Client distance validation
            if(noOfHoursAway < 0)
            {
                createClientView.ErrorMessageDistanceAway = "Distance must be positive";
                validationErrors = true;
            } else if(noOfHoursAway > 20)
            {
                createClientView.ErrorMessageDistanceAway = "Distance must be closer than 20 hours";
                validationErrors = true;
            }

            //If no validation errors add client to DB
            if(validationErrors == false)
            {
                clientModel.addNewClient(clientName, noOfHoursAway, hadClientDispute);
                return true;
            } else
            {
                return false;
            }
            
        }
    }
}
