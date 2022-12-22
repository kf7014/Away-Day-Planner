using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;

namespace Away_Day_Planner.Views
{
    public class AddActivityPresenter
    {
        IAddActivityView addActivityView;

        public AddActivityPresenter(IAddActivityView addActivityView)
        {
            this.addActivityView = addActivityView;
            addActivityView.register(this);
        }
    }
}
