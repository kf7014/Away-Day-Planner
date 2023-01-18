using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;
using Away_Day_Planner.Models.Login;

namespace Away_Day_Planner.Presenters
{
    public class LoginUserPresenter
    {
        ILoginView createLoginView;
        private ILoginRegistrationModel LoginRegistrationModel;
        private LoginView loginView;

        public LoginUserPresenter(ILoginView createLoginViewm, ILoginRegistrationModel loginRegistrationModel)
        {
            this.createLoginView = createLoginView;
            this.LoginRegistrationModel = LoginRegistrationModel;
            createLoginView.register(this);
        }

        public LoginUserPresenter(LoginView loginView, LoginRegistrationModel loginRegistrationModel)
        {
            this.loginView = loginView;
            LoginRegistrationModel = loginRegistrationModel;
        }
    }
}



