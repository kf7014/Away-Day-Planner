using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;

namespace Away_Day_Planner.Presenters
{
    public class LoginUserPresenter
    {
        ILoginView createLoginView;


        public LoginUserPresenter(ILoginView createLoginView)
        {
            this.createLoginView = createLoginView;
            createLoginView.register(this);
        }
    }
}
