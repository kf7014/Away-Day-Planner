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

        private void buttonCreateClient_Click(object sender, EventArgs e)
        {
            CreateClientView createClientView = new CreateClientView();
            CreateClientPresenter createClientPresenter = new CreateClientPresenter(createClientView);
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
            ClientModel clientModel = new ClientModel();
            EventBookerView eventBookerView = new EventBookerView();
            EventBookerPresenter eventBookerPresenter = new EventBookerPresenter(eventBookerView, clientModel);
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
    }
}
