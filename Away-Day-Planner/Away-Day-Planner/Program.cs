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
            ClientDepartmentSelectionView clientDepartmentSelectionView = new ClientDepartmentSelectionView();
            ClientModel clientModel = new ClientModel();
            ClientDepartmentSelectionPresenter clientDepartmentSelectionPresenter = new ClientDepartmentSelectionPresenter(clientDepartmentSelectionView, clientModel);

            //System point of entry
            Application.Run(clientDepartmentSelectionView);  
        }
    }
}
