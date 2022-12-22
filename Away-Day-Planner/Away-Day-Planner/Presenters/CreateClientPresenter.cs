using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;

namespace Away_Day_Planner.Presenters
{
    public class CreateClientPresenter
    {
        ICreateClientView createClientView;

        public CreateClientPresenter(ICreateClientView createClientView)
        {
            this.createClientView = createClientView;
            createClientView.register(this);
        }
    }
}
