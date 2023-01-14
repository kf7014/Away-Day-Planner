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
    public partial class CreateClientView : Form, ICreateClientView
    {
        private CreateClientPresenter createClientPresenter;
        public String ClientName
        {
            set { textBoxClientName.Text = value; }
            get { return textBoxClientName.Text; }
        }
        public decimal NumberOfHoursAway
        {
            set { numericUpDownNumberOfHoursAway.Value = value; }
            get { return numericUpDownNumberOfHoursAway.Value; }
        }
        public bool HadClientDispute
        {
            set { checkBoxHadClientDispute.Checked = value; }
            get { return checkBoxHadClientDispute.Checked; }
        }

        public CreateClientView()
        {
            InitializeComponent();
        }

        public void register(CreateClientPresenter createClientPresenter)
        {
            this.createClientPresenter = createClientPresenter;

        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            //NEEDS FORM SECURITY ADDING
            createClientPresenter.buttonAddClientClickEvent();
            this.Close();
        }
    }
}
