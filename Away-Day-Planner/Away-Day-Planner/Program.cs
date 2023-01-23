/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009505
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Away_Day_Planner.Views;
using Away_Day_Planner.Models.ClientDepartment;
using Away_Day_Planner.Presenters;
using System.Collections;
using Away_Day_Planner.Utilities;
using Away_Day_Planner.Database;
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity;
using Away_Day_Planner.Models.Login;
using Away_Day_Planner.Security;

namespace Away_Day_Planner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            ArgumentParser arg_p = new ArgumentParser(args);
            arg_p.SetSettings();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Create Model, View and Presenter for ClientDepartmentSelection
           

            LoginView loginView = new LoginView();
            LoginRegistrationModel loginRegistrationModel = new LoginRegistrationModel();
            LoginUserPresenter loginUserPresenter = new LoginUserPresenter(loginView, loginRegistrationModel);
            //System point of entry
            Application.Run(loginView);

            ////Uncomment this paragraph and comment one above to go straight to registration page. Only use to create first user and then use other entry point for rest of system and to create other users
            //RegisterView registerView = new RegisterView();
            //LoginRegistrationModel loginRegistrationModel = new LoginRegistrationModel();
            //RegisterUserPresenter registerUserPresenter = new RegisterUserPresenter(registerView, loginRegistrationModel);
            ////Alternative system point of entry to go straight to register user
            //Application.Run(registerView);
        }
    }
}
