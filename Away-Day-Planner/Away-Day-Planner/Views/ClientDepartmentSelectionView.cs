﻿using System;
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
    public partial class ClientDepartmentSelectionView : Form
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
    }
}
