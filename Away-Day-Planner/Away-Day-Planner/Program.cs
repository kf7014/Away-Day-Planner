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
using Away_Day_Planner.Presenters;
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
            //Application.Run(loginView);  

            RegisterView registerView = new RegisterView();
            RegisterUserPresenter registerUserPresenter = new RegisterUserPresenter(registerView, loginRegistrationModel);

            Application.Run(registerView);
        }
    }
}
