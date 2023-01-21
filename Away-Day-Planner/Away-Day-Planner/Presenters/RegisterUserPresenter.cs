﻿using System;
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
        private ILoginRegistrationModel LoginRegistrationModel;

        public RegisterUserPresenter(IRegisterView createRegisterView, ILoginRegistrationModel LoginRegistrationModel)
        {
            this.createRegisterView = createRegisterView;
            this.LoginRegistrationModel = LoginRegistrationModel;
            createRegisterView.register(this);
        }


        public bool registerNewUserEvent()
        {
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
                else if (firstNameError == false)
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
                    createRegisterView.ErrorMessageFirstName = "First name cannot be empty";
                    firstNameError = true;
                    validationError = true;
                }
                else if (lastNameError == false)
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
                    createRegisterView.ErrorMessageFirstName = "First name cannot be empty";
                    firstNameError = true;
                    validationError = true;
                }
                else if (usernameError == false)
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
                    createRegisterView.ErrorMessageFirstName = "First name cannot be empty";
                    firstNameError = true;
                    validationError = true;
                }
                else if (emailError == false)
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
                    createRegisterView.ErrorMessageFirstName = "First name cannot be empty";
                    firstNameError = true;
                    validationError = true;
                }
                else if (passwordError == false)
                {
                    createRegisterView.ErrorMessagePassword = "";
                }


            
            if (validationError == false)
            {
                LoginRegistrationModel.addNewUser(firstName, lastName, username, userEmail, userPassword);
                return true;
            }
            else
            {
                return false;
            }

            }
        }

    }





