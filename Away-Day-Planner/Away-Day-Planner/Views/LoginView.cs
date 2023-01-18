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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            ClientDepartmentSelectionView clientDepartmentSelectionView = new ClientDepartmentSelectionView();
            this.Hide();
            clientDepartmentSelectionView.ShowDialog();
        }
    }
}
