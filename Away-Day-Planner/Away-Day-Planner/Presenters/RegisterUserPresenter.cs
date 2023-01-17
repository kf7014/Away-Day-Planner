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
                createRegisterView.ErrorMessageFirstName = "First name must be longer than 2 characters";
                validationError = true;
            }
            else if (firstName.Length > 50)
            {
                createRegisterView.ErrorMessageFirstName = "First name must be shorter than 50 characters";
                validationError = true;
            }
            else if (firstName == null)
            {
                createRegisterView.ErrorMessageFirstName = "First name cannot be empty";
                validationError = true;
            }

            //last name
            if (lastName.Length < 2)
            {
                createRegisterView.ErrorMessageLastName = "First name must be longer than 2 characters";
                validationError = true;
            }
            else if (firstName.Length > 50)
            {
                createRegisterView.ErrorMessageLastName = "First name must be shorter than 50 characters";
                validationError = true;
            }
            else if (firstName == null)
            {
                createRegisterView.ErrorMessageLastName = "Client name cannot be empty";
                validationError = true;
            }

            //username
            if (firstName.Length < 5)
            {
                createRegisterView.ErrorMessageUsername = "Username must be longer than 5 characters";
                validationError = true;
            }
            else if (firstName.Length > 20)
            {
                createRegisterView.ErrorMessageUsername = "Username must be shorter than 20 characters";
                validationError = true;
            }
            else if (firstName == null)
            {
                createRegisterView.ErrorMessageUsername = "Username cannot be empty";
                validationError = true;
            }

            //user email
            if (firstName.Length < 10)
            {
                createRegisterView.ErrorMessageEmail = "E-mail must be longer than 10 characters";
                validationError = true;
            }
            else if (firstName.Length > 50)
            {
                createRegisterView.ErrorMessageEmail = "E-mail name must be shorter than 50 characters";
                validationError = true;
            }
            else if (firstName == null)
            {
                createRegisterView.ErrorMessageEmail = "E-mail name cannot be empty";
                validationError = true;
            }

            //user password
            if (firstName.Length < 8)
            {
                createRegisterView.ErrorMessagePassword = "Password must be longer than 8 characters";
                validationError = true;
            }
            else if (firstName.Length > 50)
            {
                createRegisterView.ErrorMessagePassword = "Password name must be shorter than 50 characters";
                validationError = true;
            }
            else if (firstName == null)
            {
                createRegisterView.ErrorMessagePassword = "Password name cannot be empty";
                validationError = true;
            }

            //user role
            if (firstName.Length < 2)
            {
                createRegisterView.ErrorMessageRole = "Role must be longer than 2 characters";
                validationError = true;
            }
            else if (firstName.Length > 20)
            {
                createRegisterView.ErrorMessageRole = "Role must be shorter than 20 characters";
                validationError = true;
            }
            else if (firstName == null)
            {
                createRegisterView.ErrorMessageRole = "Role name cannot be empty";
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





