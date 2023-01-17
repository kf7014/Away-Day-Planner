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

        private void registerNewUserButton_Click(object sender, EventArgs e)
        {
            registerUserPresenter.registerNewUserEvent();

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(userPassword);
            Console.WriteLine(userEmail);
            Console.WriteLine(username);
            Console.WriteLine(userRole);
        }
        //registerNewUserButton
        //end of retrieving data from form//

    }
}
