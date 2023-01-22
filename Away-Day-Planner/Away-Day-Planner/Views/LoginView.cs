/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009595
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Away_Day_Planner.Models.ClientDepartment;
using Away_Day_Planner.Models.Login;
using Away_Day_Planner.Presenters;

namespace Away_Day_Planner.Views
{
    public partial class LoginView : Form, ILoginView
    {
        private LoginUserPresenter loginUserPresenter;
        public LoginView()
        {
            InitializeComponent();
        }


        public void register(LoginUserPresenter loginUserPresenter)
        {
            this.loginUserPresenter = loginUserPresenter;

        }

        //getting data from user input on login form
        public String loginUsername
        {
            get { return userLogin.Text; } 
            set {}
        }

        public String loginPassword
        {
            get { return userPassword.Text; }
            set {}
        }

        //error messages for data validation
        public String LoginErrorMessageUsername
        {
            get { return loginErrorMessageUsername.Text; }
            set { loginErrorMessageUsername.Text = value; }
        }

        public String LoginErrorMessagePassword
        {
            get { return loginErrorMessagePassword.Text; }
            set { loginErrorMessagePassword.Text = value; }
        }

        public String LoginErrorInvalidDetails
        {
            get { return labelErrorInvalidDetails.Text; }
            set { labelErrorInvalidDetails.Text = value; }
        }



        private void loginButton_Click(object sender, EventArgs e)
        {
            //login user check
            bool success = loginUserPresenter.loginUserEvent();
            if (success)
            {

                ClientDepartmentSelectionView clientDepartmentSelectionView = new ClientDepartmentSelectionView();

                ClientModel clientModel = new ClientModel();
                ClientDepartmentSelectionPresenter clientDepartmentSelectionPresenter = new ClientDepartmentSelectionPresenter(clientDepartmentSelectionView, clientModel);
                this.Hide();
                clientDepartmentSelectionView.ShowDialog();
                this.Show();
            }
        }
    }
}
