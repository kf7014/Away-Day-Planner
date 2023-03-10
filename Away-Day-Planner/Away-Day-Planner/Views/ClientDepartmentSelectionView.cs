/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009505
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
using Away_Day_Planner.Presenters;
using Away_Day_Planner.Models.ClientDepartment;
using Away_Day_Planner.Models.EventBooker;
using Away_Day_Planner.Models.Login;


namespace Away_Day_Planner.Views
{
    public partial class ClientDepartmentSelectionView : Form, IClientDepartmentSelectionView
    {
        private ClientDepartmentSelectionPresenter clientDepartmentSelectionPresenter;

        public ClientDepartmentSelectionView()
        {
            InitializeComponent();
        }

        //Getters and setters for form elements
        public int selectedClientIndex
        {
            set { }
            get { return listBoxClient.SelectedIndex; }
        }
        public int selectedDepartmentIndex
        {
            set { }
            get { return listBoxDepartment.SelectedIndex; }
        }
        public String ErrorConfirmSelection
        {
            set { labelConfirmSelectionError.Text = value; }
            get { return labelConfirmSelectionError.Text; }
        }

        private void buttonCreateClient_Click(object sender, EventArgs e)
        {
            clientDepartmentSelectionPresenter.buttonCreateClientClickEvent();
        }

        private void buttonCreateDepartment_Click(object sender, EventArgs e)
        {
            clientDepartmentSelectionPresenter.buttonCreateDepartmentClickEvent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            bool success = clientDepartmentSelectionPresenter.buttonConfirmClickEvent();

            if (success)
            {
                //Create Model and View for EventBooker
                EventModel eventModel = new EventModel();
                ClientModel clientModel = new ClientModel();
                eventModel.setParents(listBoxClient.SelectedIndex, listBoxDepartment.SelectedIndex);
                eventModel.addNewEvent();
                EventBookerView eventBookerView = new EventBookerView();
                EventBookerPresenter eventBookerPresenter = new EventBookerPresenter(eventBookerView, eventModel, clientModel);
                this.Hide();
                eventBookerView.ShowDialog();
                this.Show();
            }
            
        }

        public void register(ClientDepartmentSelectionPresenter clientDepartmentSelectionPresenter)
        {
            this.clientDepartmentSelectionPresenter = clientDepartmentSelectionPresenter;

        }

        public void setClientList(string[] names)
        {
            listBoxClient.DataSource = names;
        }

        public void setDepartmentList(string[] names)
        {
            listBoxDepartment.DataSource = names;
        }

        private void listBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientDepartmentSelectionPresenter.listBoxClientSelectionEvent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //on click take user to register new user view
            RegisterView registerView = new RegisterView();
            LoginRegistrationModel loginRegistrationModel = new LoginRegistrationModel();
            RegisterUserPresenter registerUserPresenter = new RegisterUserPresenter(registerView ,loginRegistrationModel);
            this.Hide();
            registerView.ShowDialog();
            this.Show();
            
        }
    }
}
