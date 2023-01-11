using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;

namespace Away_Day_Planner.Presenters
{
    class RegisterUserPresenter
    {
        IRegisterView createRegisterView;


        public RegisterUserPresenter(IRegisterView registerView)
        {
            this.createRegisterView = createRegisterView;
            createRegisterView.register(this);
        }
    }
}




