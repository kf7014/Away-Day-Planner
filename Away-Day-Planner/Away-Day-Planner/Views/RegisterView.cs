using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Away_Day_Planner.Presenters;
using Away_Day_Planner.Models.Login;


namespace Away_Day_Planner.Views
{
    public partial class RegisterView : Form, IRegisterView
    {
        private ClientDepartmentSelectionView clientDepartmentSelectionView;
        private RegisterUserPresenter registerUserPresenter;
        public RegisterView()
        {
            InitializeComponent();
        }

        public void register(RegisterUserPresenter registerUserPresenter)
        {
            this.registerUserPresenter = registerUserPresenter;

        }

        //retrieving data from form and setting it//
        public String firstName
        {
            get { return staffFirstName.Text; }
            set { staffFirstName.Text = value; }
        }
        public String lastName
        {
            get { return staffLastName.Text; }
            set { staffLastName.Text = value; }
        }
        public String userPassword
        {
            get { return staffPassword.Text ; }
            set { staffPassword.Text = value; }
        }
        public String userEmail
        {
            get { return staffEmail.Text; }
            set { staffEmail.Text = value; }
        }
        public String username
        {
            get { return staffUsername.Text; }
            set { staffUsername.Text = value; }
        }


        //error messages for data validation
        public String ErrorMessageFirstName
        {
            get { return errorMessageFirstName.Text; }
            set { errorMessageFirstName.Text = value; }
        }

        public String ErrorMessageLastName
        {
            get { return errorMessageLastName.Text; }
            set { errorMessageLastName.Text = value; }
        }

        public String ErrorMessageUsername
        {
            get { return errorMessageUsername.Text; }
            set { errorMessageUsername.Text = value; }
        }

        public String ErrorMessageEmail
        {
            get { return errorMessageEmail.Text; }
            set { errorMessageEmail.Text = value; }
        }

        public String ErrorMessagePassword
        {
            get { return errorMessagePassword.Text; }
            set { errorMessagePassword.Text = value; }
        }




        private void registerNewUserButton_Click(object sender, EventArgs e)
        {
            //register new user
            bool success = registerUserPresenter.registerNewUserEvent();
            if (success)
            {
                //on click take user to client department selection view
                ClientDepartmentSelectionView clientDepartmentSelectionView = new ClientDepartmentSelectionView();
                this.Hide();
                clientDepartmentSelectionView.ShowDialog();
            }

            
        }

        private void RegisterView_Load(object sender, EventArgs e)
        {

        }

        private void backRegisterButton_Click(object sender, EventArgs e)
        {
            //on click take user to client department selection view
            ClientDepartmentSelectionView clientDepartmentSelectionView = new ClientDepartmentSelectionView();
            this.Hide();
            clientDepartmentSelectionView.ShowDialog();
        }


        //registerNewUserButton
        //end of retrieving data from form//

    }
}
