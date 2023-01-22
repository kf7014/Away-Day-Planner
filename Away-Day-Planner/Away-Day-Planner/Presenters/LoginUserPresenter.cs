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
        private ILoginView createLoginView;
        private ILoginRegistrationModel loginRegistrationModel;
        //private LoginView loginView;

        public LoginUserPresenter(ILoginView createLoginView, ILoginRegistrationModel LoginRegistrationModel)
        {
            this.createLoginView = createLoginView;
            this.loginRegistrationModel = LoginRegistrationModel;
            createLoginView.register(this);
        }

        public bool loginUserEvent()
        {
            String loginUsername = createLoginView.loginUsername;
            String loginPassword = createLoginView.loginPassword;
         
            bool validationError = false;
            bool loginPasswordError = false;
            bool loginUsernameError = false;

            if (loginUsername == null)
            {
                createLoginView.LoginErrorMessageUsername = "Username cannot be empty";
                loginUsernameError = true;
                validationError = true;
            }
            else if (loginUsername == String.Empty)
            {
                createLoginView.LoginErrorMessageUsername = "Username cannot be empty";
                loginUsernameError = true;
                validationError = true;
            } else
            {
                loginUsernameError = true;
                createLoginView.LoginErrorMessageUsername = "";
            }

            if (loginPassword == null)
            {
                createLoginView.LoginErrorMessagePassword = "Password cannot be empty";
                loginPasswordError = true;
                validationError = true;
            }
            else if (loginPassword == String.Empty)
            {
                createLoginView.LoginErrorMessagePassword = "Password cannot be empty";
                loginPasswordError = true;
                validationError = true;
            } else
            {
                createLoginView.LoginErrorMessagePassword = "";
                loginPasswordError = false;
            }



            if (validationError == false)
            {
                //TODO
                //if (validatecredentials(loginUsername,loginPassword))
                //{
                //take user to main form
                // }
                // else
                //{
                //incorrect password
                // }

                User[] users = loginRegistrationModel.getAllUsers();
                foreach (User user in users)
                {
                    if (user.username == loginUsername)
                    {
                        if (user.userPassword == loginPassword)
                        {
                            User userLoggedIn = loginRegistrationModel.getUserFromLogin(loginUsername, loginPassword);
                            createLoginView.LoginErrorInvalidDetails = "";
                            Console.WriteLine(userLoggedIn.username);
                            return true;
                        }
                    }
                }
            }
            createLoginView.LoginErrorInvalidDetails = "Invalid login credentials";
            return false;
            


        }
    }
}



