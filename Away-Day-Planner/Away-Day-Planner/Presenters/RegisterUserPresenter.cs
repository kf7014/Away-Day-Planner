using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;

namespace Away_Day_Planner.Presenters
{
    public class RegisterUserPresenter
    {
        IRegisterView createRegisterView;


        public RegisterUserPresenter(IRegisterView createRegisterView)
        {
            this.createRegisterView = createRegisterView;
            createRegisterView.register(this);
        }
    }
}




