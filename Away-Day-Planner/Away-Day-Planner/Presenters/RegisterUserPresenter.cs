/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009505
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using Away_Day_Planner.Models.Login;
using Away_Day_Planner.Security;
using Away_Day_Planner.Views;
using System;
using System.Text.RegularExpressions;

namespace Away_Day_Planner.Presenters
{
    public class RegisterUserPresenter
    {
        private IRegisterView createRegisterView;
        private ILoginRegistrationModel LoginRegistrationModel;

        public RegisterUserPresenter(IRegisterView createRegisterView, ILoginRegistrationModel LoginRegistrationModel)
        {
            this.createRegisterView = createRegisterView;
            this.LoginRegistrationModel = LoginRegistrationModel;
            createRegisterView.register(this);
        }


        public bool registerNewUserEvent()
        {
            //Regex for invalid characters
            String firstNameRegex = @"^([a-zA-Z]+?)([-\s'][a-zA-Z]+)*?$";
            String lastNameRegex = @"^([a-zA-Z]+?)([-\s'][a-zA-Z]+)*?$";
            String usernameRegex = @"^[A-Za-z0-9]*$";
            String emailRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            String passwordRegex = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$";

            Regex firstRg = new Regex(firstNameRegex);
            Regex lastRg = new Regex(lastNameRegex);
            Regex userRg = new Regex(usernameRegex);
            Regex emailRg = new Regex(emailRegex);
            Regex passRg = new Regex(passwordRegex);


            String firstName = createRegisterView.firstName;
            String lastName = createRegisterView.lastName;
            String username = createRegisterView.username;
            String userEmail = createRegisterView.userEmail;
            String userPassword = createRegisterView.userPassword;



            bool validationError = false;
            bool firstNameError = false;
            bool lastNameError = false;
            bool usernameError = false;
            bool emailError = false;
            bool passwordError = false;



            //validation
            //first name

            if (firstName.Length <= 2)
            {
                createRegisterView.ErrorMessageFirstName = "First name must be longer than 2 characters";
                firstNameError = true;
                validationError = true;
            }
            else if (firstName.Length > 50)
            {
                createRegisterView.ErrorMessageFirstName = "First name must be shorter than 50 characters";
                firstNameError = true;
                validationError = true;
            }

            else if (firstName == null)
            {
                createRegisterView.ErrorMessageFirstName = "First name cannot be empty";
                firstNameError = true;
                validationError = true;
            }
            else if (firstName == String.Empty)
            {
                createRegisterView.ErrorMessageFirstName = "First name cannot be empty";
                firstNameError = true;
                validationError = true;
            }
            else if (!firstRg.IsMatch(firstName))
            {
                createRegisterView.ErrorMessageFirstName = "First name can only contain letters";
                firstNameError = true;
                validationError = true;
            }
            else if (firstNameError == false && (firstRg.IsMatch(firstName)))

            {
                createRegisterView.ErrorMessageFirstName = "";

            }

            //last name
            if (lastName.Length < 2)
            {
                createRegisterView.ErrorMessageLastName = "Last name must be longer than 2 characters";
                lastNameError = false;
                validationError = true;
            }
            else if (lastName.Length > 50)
            {
                createRegisterView.ErrorMessageLastName = "Last name must be shorter than 50 characters";
                lastNameError = false;
                validationError = true;
            }
            else if (lastName == null)
            {
                createRegisterView.ErrorMessageLastName = "Last name cannot be empty";
                lastNameError = false;
                validationError = true;
            }
            else if (lastName == String.Empty)
            {
                createRegisterView.ErrorMessageLastName = "Last name cannot be empty";
                lastNameError = true;
                validationError = true;
            } 
            else if (!lastRg.IsMatch(lastName))
            {
                createRegisterView.ErrorMessageLastName = "Last can only contain letters";
                lastNameError = true;
                validationError = true;
            }
            else if (lastNameError == false && (firstRg.IsMatch(lastName)))
            {
                createRegisterView.ErrorMessageLastName = "";
            }

            //username
            if (username.Length < 5)
            {
                createRegisterView.ErrorMessageUsername = "Username must be longer than 5 characters";
                usernameError = false;
                validationError = true;
            }
            else if (username.Length > 20)
            {
                createRegisterView.ErrorMessageUsername = "Username must be shorter than 20 characters";
                usernameError = false;
                validationError = true;
            }
            else if (username == null)
            {
                createRegisterView.ErrorMessageUsername = "Username cannot be empty";
                usernameError = false;
                validationError = true;
            }
            else if (username == String.Empty)
            {
                createRegisterView.ErrorMessageUsername = "Username name cannot be empty";
                usernameError = true;
                validationError = true;
            }
            else if (!userRg.IsMatch(username))
            {
                createRegisterView.ErrorMessageUsername = "Username can only contain letters and numbers";
                usernameError = true;
                validationError = true;
            }
            else if (usernameError == false && (userRg.IsMatch(username)))
            {
                createRegisterView.ErrorMessageUsername = "";
            }

            //user email
            if (userEmail.Length < 10)
            {
                createRegisterView.ErrorMessageEmail = "E-mail must be longer than 10 characters";
                emailError = false;
                validationError = true;
            }
            else if (userEmail.Length > 50)
            {
                createRegisterView.ErrorMessageEmail = "E-mail name must be shorter than 50 characters";
                emailError = false;
                validationError = true;
            }
            else if (userEmail == null)
            {
                createRegisterView.ErrorMessageEmail = "E-mail name cannot be empty";
                emailError = false;
                validationError = true;
            }
            else if (userEmail == String.Empty)
            {
                createRegisterView.ErrorMessageEmail = "E-mail name cannot be empty";
                emailError = true;
                validationError = true;
            }
            else if (!emailRg.IsMatch(userEmail))
            {
                createRegisterView.ErrorMessageEmail = "Please enter a valid email";
                emailError = true;
                validationError = true;
            }
            else if (emailError == false && (emailRg.IsMatch(userEmail)))
            {
                createRegisterView.ErrorMessageEmail = "";
            }

            //user password
            if (userPassword.Length < 8)
            {
                createRegisterView.ErrorMessagePassword = "Password must be longer than 8 characters";
                passwordError = false;
                validationError = true;
            }
            else if (userPassword.Length > 50)
            {
                createRegisterView.ErrorMessagePassword = "Password name must be shorter than 50 characters";
                passwordError = false;
                validationError = true;
            }
            else if (userPassword == null)
            {
                createRegisterView.ErrorMessagePassword = "Password name cannot be empty";
                passwordError = false;
                validationError = true;
            }
            else if (userPassword == String.Empty)
            {
                createRegisterView.ErrorMessagePassword = "Password cannot be empty";
                passwordError = true;
                validationError = true;
            }
            else if (!passRg.IsMatch(userPassword))
            {
                createRegisterView.ErrorMessagePassword = "Password must contain atleast one number and one special character";
                passwordError = true;
                validationError = true;
            }
            else if (emailError == false && (passRg.IsMatch(userPassword)))
            {
                createRegisterView.ErrorMessagePassword = "";
            }





            if (validationError == false)
            {
                Tuple<string, byte[]> hashSalt = Hashing.HashPassword(userPassword);


                LoginRegistrationModel.addNewUser(firstName, lastName, username, userEmail, hashSalt.Item1, hashSalt.Item2);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}







