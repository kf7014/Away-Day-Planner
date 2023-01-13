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
        }
    }
}
