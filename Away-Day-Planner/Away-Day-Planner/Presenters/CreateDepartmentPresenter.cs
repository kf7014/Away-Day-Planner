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

        public void buttonAddClientClickEvent()
        {
            String clientName = createDepartmentView.ClientName;
            int selectedClientId = createDepartmentView.SelectedClientId;
            String departmentName = createDepartmentView.DepartmentName;
            Console.WriteLine("Department would be added with following details: ");
            Console.WriteLine("Department Name " + departmentName);
            Console.WriteLine("Associated Client: " + clientName);
            Console.WriteLine("Associated Client Key: " + selectedClientId);
            //clientModel.addNewDepartment(departmentName, clientId);
        }
    }
}
