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

namespace Away_Day_Planner.Views
{
    public partial class ClientDepartmentSelectionView : Form, IClientDepartmentSelectionView
    {
        private ClientDepartmentSelectionPresenter clientDepartmentSelectionPresenter;

        public ClientDepartmentSelectionView()
        {
            InitializeComponent();
        }

        public int selectedClientIndex
        {
            set { }
            get { return listBoxClient.SelectedIndex; }
        }


        private void buttonCreateClient_Click(object sender, EventArgs e)
        {
            //TODO: Move out of view and into presenter
            CreateClientView createClientView = new CreateClientView();
            ClientModel clientModel = new ClientModel();
            CreateClientPresenter createClientPresenter = new CreateClientPresenter(createClientView, clientModel);
            createClientView.ShowDialog();
        }

        private void buttonCreateDepartment_Click(object sender, EventArgs e)
        {
            CreateDepartmentView createDepartmentView = new CreateDepartmentView();
            CreateDepartmentPresenter createDepartmentPresenter = new CreateDepartmentPresenter(createDepartmentView);
            createDepartmentView.ShowDialog();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            //Create Model and View for EventBooker
            EventModel eventModel = new EventModel();
            EventBookerView eventBookerView = new EventBookerView();
            EventBookerPresenter eventBookerPresenter = new EventBookerPresenter(eventBookerView, eventModel);
            this.Hide();
            eventBookerView.ShowDialog();
            this.Show();
        }

        public void register(ClientDepartmentSelectionPresenter clientDepartmentSelectionPresenter)
        {
            this.clientDepartmentSelectionPresenter = clientDepartmentSelectionPresenter;

            //CONSOLE CODE TO BE DELETED
            Console.WriteLine("presenter: " + clientDepartmentSelectionPresenter);
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
    }
}
