using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;

namespace Away_Day_Planner.Presenters
{
    public class ClientDepartmentSelectionPresenter
    {
        IClientDepartmentSelectionView clientDepartmentSelectionView;

        public ClientDepartmentSelectionPresenter(IClientDepartmentSelectionView clientDepartmentSelectionView)
        {
            this.clientDepartmentSelectionView = clientDepartmentSelectionView;
            clientDepartmentSelectionView.register(this);
        }

    }
}
