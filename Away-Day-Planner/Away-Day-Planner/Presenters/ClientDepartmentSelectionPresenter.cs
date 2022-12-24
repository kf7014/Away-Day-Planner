using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;
using Away_Day_Planner.Models.EventBooker;

namespace Away_Day_Planner.Presenters
{
    public class ClientDepartmentSelectionPresenter
    {
        private IClientDepartmentSelectionView clientDepartmentSelectionView;
        private IClientModel clientModel;

        public ClientDepartmentSelectionPresenter(IClientDepartmentSelectionView clientDepartmentSelectionView, IClientModel clientModel)
        {
            this.clientDepartmentSelectionView = clientDepartmentSelectionView;
            this.clientModel = clientModel;
            clientDepartmentSelectionView.register(this);
            populateScreen();
        }

        private void populateScreen()
        {
            Client[] list = clientModel.getClientList();
            String[] names = new String[list.Length];
            for(int i=0; i<list.Length; i++)
            {
                names[i] = list[i].name;
            }
            clientDepartmentSelectionView.setClientList(names);
        }

    }
}
