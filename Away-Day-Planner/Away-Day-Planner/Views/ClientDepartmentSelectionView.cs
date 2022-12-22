using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Away_Day_Planner.Views
{
    public partial class ClientDepartmentSelectionView : Form, IClientDepartmentSelectionView
    {
        public ClientDepartmentSelectionView()
        {
            InitializeComponent();
        }

        private void buttonCreateClient_Click(object sender, EventArgs e)
        {
            CreateClientView createClientView = new CreateClientView();
            createClientView.ShowDialog();
        }

        private void buttonCreateDepartment_Click(object sender, EventArgs e)
        {
            CreateDepartmentView createDepartmentView = new CreateDepartmentView();
            createDepartmentView.ShowDialog();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            EventBookerView eventBookerView = new EventBookerView();
            this.Hide();
            eventBookerView.ShowDialog();
            this.Show();
        }
    }
}
