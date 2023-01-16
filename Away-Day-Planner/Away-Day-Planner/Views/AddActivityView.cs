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
    public partial class AddActivityView : Form, IAddActivityView
    {
        private AddActivityPresenter addActivityPresenter;
        public AddActivityView()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRewardsRequired_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddActivity_Click(object sender, EventArgs e)
        {
            //NEEDS FORM SECURITY ADDING

            this.Close();
        }

        private void buttonAddCustomActivity_Click(object sender, EventArgs e)
        {
            //NEEDS FORM SECURITY ADDING

            this.Close();
        }

        public void register(AddActivityPresenter addActivityPresenter)
        {
            this.addActivityPresenter = addActivityPresenter;
        }

        public void setActivityTemplateList(string[] activityNames)
        {
            comboBoxSelectActivity.DataSource = activityNames;
        }

        public void setRewardTemplateList(string[] rewardNames)
        {
            comboBoxRewardsRequired.DataSource = rewardNames;
        }
    }
}
