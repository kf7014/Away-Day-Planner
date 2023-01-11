using Away_Day_Planner.Presenters;
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
    public partial class CreateDepartmentView : Form, ICreateDepartmentView
    {
        private CreateDepartmentPresenter createDepartmentPresenter;
        private int[] clientKeys;

        public String ClientName
        {
            set { comboBoxClientSelection.Text = value;  }
            get { return comboBoxClientSelection.Text; }
        }
        public int SelectedClientId
        {
            set { clientKeys[comboBoxClientSelection.SelectedIndex] = value; }
            get { return clientKeys[comboBoxClientSelection.SelectedIndex]; }
        }
        public String DepartmentName
        {
            set { textBoxDepartmentName.Text = value; }
            get { return textBoxDepartmentName.Text; }
        }

        public int ClientName
        {
            set { comboBoxClientSelection.SelectedIndex = value;  }
            get { return comboBoxClientSelection.SelectedIndex; }
        }
        public String DepartmentName
        {
            set { textBoxDepartmentName.Text = value; }
            get { return textBoxDepartmentName.Text; }
        }

        public CreateDepartmentView()
        {
            InitializeComponent();
        }

        public void register(CreateDepartmentPresenter createDepartmentPresenter)
        {
            this.createDepartmentPresenter = createDepartmentPresenter;

            //CONSOLE CODE TO BE DELETED
            Console.WriteLine("presenter: " + createDepartmentPresenter);
        }

        public void setClientList(string[] names, int[] keys)
        {
            comboBoxClientSelection.DataSource = names;
            this.clientKeys = keys;
            Console.WriteLine(clientKeys);
        }

        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {
            //NEEDS FORM SECURITY ADDING
            createDepartmentPresenter.buttonAddDepartmentClickEvent();
            this.Close();
        }
    }
}
