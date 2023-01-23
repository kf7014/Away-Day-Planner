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
    public class CreateDepartmentPresenter
    {
        private ICreateDepartmentView createDepartmentView;
        private IClientModel clientModel;

        public CreateDepartmentPresenter(ICreateDepartmentView createDepartmentView, IClientModel clientModel)
        {
            this.createDepartmentView = createDepartmentView;
            this.clientModel = clientModel;
            createDepartmentView.register(this);
            populateScreen();
        }

        //Update UI
        private void populateScreen()
        {
            //Populate combobox with clients
            Client[] list = clientModel.getClientList();
            String[] names = new String[list.Length];
            int[] keys = new int[list.Length];

            for (int i = 0; i < list.Length; i++)
            {
                names[i] = list[i].name;
                keys[i] = list[i].id;
            }
            
            createDepartmentView.setClientList(names, keys);          
        }

        //Runs when add department button is pressed
        public bool buttonAddDepartmentClickEvent()
        {
            String clientName = createDepartmentView.ClientName;        
            String departmentName = createDepartmentView.DepartmentName;

            bool validationErrors = false;

            //Client selection validation
            if(clientName == null)
            {
                createDepartmentView.ErrorMessageClientSelection = "Client cannot be null";
                validationErrors = true;
            } else if(clientName == "")
            {
                createDepartmentView.ErrorMessageClientSelection = "Client cannot be empty";
            }

            if (departmentName.Length < 2)
            {
                createDepartmentView.ErrorMessageDepartmentName = "Department name must be longer than 2 characters";
                validationErrors = true;
            }
            else if (departmentName.Length > 50)
            {
                createDepartmentView.ErrorMessageDepartmentName = "Department name must be shorter than 50 characters";
                validationErrors = true;
            }
            else if (departmentName == null)
            {
                createDepartmentView.ErrorMessageDepartmentName = "Department name cannot be null";
                validationErrors = true;
            }

            //Add department to DB if no validation errors
            if(validationErrors == false)
            {
                int selectedClientId = createDepartmentView.SelectedClientId;
                Client client = clientModel.getClient(selectedClientId);
                clientModel.addNewDepartment(departmentName, client);
                return true;
            } else 
            {
                return false;
            }
            
        }
    }
}
