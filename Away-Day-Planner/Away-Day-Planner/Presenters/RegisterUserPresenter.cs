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

        public bool registerNewUserEvent()
        {
            String firstName = createRegisterView.firstName;
            String lastName = createRegisterView.lastName;
            String username = createRegisterView.username;
            String userEmail = createRegisterView.userEmail;
            String userPassword = createRegisterView.userPassword;
            String userRole = createRegisterView.userRole;

            bool validationError = false;

            //validation
            //first name
            if (firstName.Length < 2)
            {
                createRegisterView.ErrorMessageName = "First name must be longer than 2 characters";
                validationError = true;
            }
            else if (firstName.Length > 50)
            {
                createRegisterView.ErrorMessageName = "First name must be shorter than 50 characters";
                validationError = true;
            }
            else if (firstName == null)
            {
                createRegisterView.ErrorMessageName = "First name cannot be empty";
                validationError = true;
            }

            //last name
            if (lastName.Length < 2)
            {
                createRegisterView.ErrorMessageName = "First name must be longer than 2 characters";
                validationError = true;
            }
            else if (firstName.Length > 50)
            {
                createRegisterView.ErrorMessageName = "First name must be shorter than 50 characters";
                validationError = true;
            }
            else if (firstName == null)
            {
                createRegisterView.ErrorMessageName = "Client name cannot be empty";
                validationError = true;
            }

            //username
            if (firstName.Length < 5)
            {
                createRegisterView.ErrorMessageName = "Username must be longer than 5 characters";
                validationError = true;
            }
            else if (firstName.Length > 20)
            {
                createRegisterView.ErrorMessageName = "Username must be shorter than 20 characters";
                validationError = true;
            }
            else if (firstName == null)
            {
                createRegisterView.ErrorMessageName = "Username cannot be empty";
                validationError = true;
            }

            //user email
            if (firstName.Length < 10)
            {
                createRegisterView.ErrorMessageName = "E-mail must be longer than 10 characters";
                validationError = true;
            }
            else if (firstName.Length > 50)
            {
                createRegisterView.ErrorMessageName = "E-mail name must be shorter than 50 characters";
                validationError = true;
            }
            else if (firstName == null)
            {
                createRegisterView.ErrorMessageName = "E-mail name cannot be empty";
                validationError = true;
            }

            //user password
            if (firstName.Length < 8)
            {
                createRegisterView.ErrorMessageName = "Password must be longer than 8 characters";
                validationError = true;
            }
            else if (firstName.Length > 50)
            {
                createRegisterView.ErrorMessageName = "Password name must be shorter than 50 characters";
                validationError = true;
            }
            else if (firstName == null)
            {
                createRegisterView.ErrorMessageName = "Password name cannot be empty";
                validationError = true;
            }

            //user role
            if (firstName.Length < 2)
            {
                createRegisterView.ErrorMessageName = "Role must be longer than 2 characters";
                validationError = true;
            }
            else if (firstName.Length > 20)
            {
                createRegisterView.ErrorMessageName = "Role must be shorter than 20 characters";
                validationError = true;
            }
            else if (firstName == null)
            {
                createRegisterView.ErrorMessageName = "Role name cannot be empty";
                validationError = true;
            }


            if (validationError == false)
            {
                LoginModel.addNewUser(firstName, lastName, username, userEmail, userPassword, userRole);
                return true;
            }
            else
            {
                return false;
            }

            }
        }

    }
}




