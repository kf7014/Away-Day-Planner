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
            if (names.Length != 0 && list.Length != 0)
            {
                createDepartmentView.setClientList(names, keys);
            }

        }
    }
}
