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


namespace Away_Day_Planner.Views
{
    public partial class RegisterView : Form, IRegisterView
    {
        private RegisterUserPresenter registerUserPresenter;
        public RegisterView()
        {
            InitializeComponent();
        }

        public void register(RegisterUserPresenter registerUserPresenter)
        {
            this.registerUserPresenter = registerUserPresenter;

        }

        //retrieving data from form//
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

        public String userRole
        {
            get { return staffRole.Text; }
            set { staffRole.Text = value; }
        }
        //error messages
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

        public String ErrorMessageRole
        {
            get { return errorMessageRole.Text; }
            set { errorMessageRole.Text = value; }
        }


        private void registerNewUserButton_Click(object sender, EventArgs e)
        {
            registerUserPresenter.registerNewUserEvent();
        }

 
        //registerNewUserButton
        //end of retrieving data from form//

    }
}
