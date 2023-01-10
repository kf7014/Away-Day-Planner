using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Presenters;

namespace Away_Day_Planner.Views
{
    public interface ICreateClientView
    {
        //Register view to presenter
        void register(CreateClientPresenter createClientPresenter);
        String ClientName { get; set; }
    }
}
