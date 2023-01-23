/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009505
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
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

        //Getters and setters for form elements
        public String ClientName
        {
            set { comboBoxClientSelection.Text = value; }
            get { return comboBoxClientSelection.Text; }
        }

        public int SelectedClientId
        {
            set { clientKeys[comboBoxClientSelection.SelectedIndex] = value; }
            get 
            {
                return (clientKeys[comboBoxClientSelection.SelectedIndex]); 
            }
        }

        public String DepartmentName
        {
            set { textBoxDepartmentName.Text = value; }
            get { return textBoxDepartmentName.Text; }
        }

        public String ErrorMessageClientSelection
        {
            set { labelErrorClientSelection.Text = value; }
            get { return labelErrorClientSelection.Text; }
        }

        public String ErrorMessageDepartmentName
        {
            set { labelErrorDepartmentName.Text = value; }
            get { return labelErrorDepartmentName.Text; }
        }

        public CreateDepartmentView()
        {
            InitializeComponent();
        }

        public void register(CreateDepartmentPresenter createDepartmentPresenter)
        {
            this.createDepartmentPresenter = createDepartmentPresenter;

        }

        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {
            bool success = createDepartmentPresenter.buttonAddDepartmentClickEvent();
            if (success)
            {
                this.Close();
            }
            
        }

        public void setClientList(string[] names, int[] keys)
        {
            comboBoxClientSelection.DataSource = names;
            if(keys != null)
            {
                this.clientKeys = keys;
            } else
            {
                this.clientKeys = new int[0];
            }
        }
    }
}
