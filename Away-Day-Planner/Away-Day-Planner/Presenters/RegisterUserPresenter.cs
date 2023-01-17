using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;
using Away_Day_Planner.Models.Login;

namespace Away_Day_Planner.Presenters
{
    public class RegisterUserPresenter
    {
        private IRegisterView createRegisterView;
        private ILoginModel LoginModel;

        public RegisterUserPresenter(IRegisterView createRegisterView, ILoginModel LoginModel)
        {
            this.createRegisterView = createRegisterView;
            this.LoginModel = LoginModel;
            createRegisterView.register(this);
        }

        public void registerNewUserEvent()
        {
            String firstName = createRegisterView.firstName;
            String lastName = createRegisterView.lastName;
            String username = createRegisterView.username;
            String userEmail = createRegisterView.userEmail;
            byte[] userPassword = createRegisterView.userPassword;
            String userRole = createRegisterView.userRole;
            //validation



        }

    }
}




