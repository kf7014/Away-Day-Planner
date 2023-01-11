using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Presenters;

namespace Away_Day_Planner.Views
{
    public interface ICreateDepartmentView
    {
        //Register view to presenter
        void register(CreateDepartmentPresenter createDepartmentPresenter);
        void setClientList(string[] names);
    }
}
