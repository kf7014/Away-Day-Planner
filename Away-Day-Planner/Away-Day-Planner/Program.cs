using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Away_Day_Planner.Views;
using Away_Day_Planner.Models.EventBooker;
using Away_Day_Planner.Presenters;

namespace Away_Day_Planner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Create Model, View and Presenter for ClientDepartmentSelection
            ClientDepartmentSelectionView clientDepartmentSelectionView = new ClientDepartmentSelectionView();           
            ClientDepartmentSelectionPresenter clientDepartmentSelectionPresenter = new ClientDepartmentSelectionPresenter(clientDepartmentSelectionView);


            //System point of entry
            Application.Run(clientDepartmentSelectionView);  
        }
    }
}
