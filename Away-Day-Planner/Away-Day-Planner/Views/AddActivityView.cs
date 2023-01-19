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

        public int selectedActivity
        {
            get { return comboBoxSelectActivity.SelectedIndex; }
            set { comboBoxSelectActivity.SelectedIndex = value; }
        }
        public int selectedReward
        {
            get { return comboBoxRewardsRequired.SelectedIndex; }
            set { comboBoxRewardsRequired.SelectedIndex = value; }
        }
        public int selectedAddition
        {
            get { return comboBoxAdditions.SelectedIndex; }
            set { comboBoxAdditions.SelectedIndex = value; }
        }
        public String totalPrice
        {
            get { return labelPriceValue.Text; }
            set { labelPriceValue.Text = value.ToString(); }
        }
        public String selectedActivityName
        {
            get { return comboBoxSelectActivity.Text; }
            set { comboBoxSelectActivity.Text = value; }
        }
        public String selectedRewardName
        {
            get { return comboBoxRewardsRequired.Text; }
            set { comboBoxRewardsRequired.Text = value; }
        }
        public String selectedAdditionName
        {
            get { return comboBoxAdditions.Text; }
            set { comboBoxAdditions.Text = value; }
        }
        public bool facilitatorRequired
        {
            get { return checkBoxFacilitator.Checked; }
            set { checkBoxFacilitator.Checked = value; }
        }

        private void buttonAddActivity_Click(object sender, EventArgs e)
        {
            //NEEDS FORM SECURITY ADDING
            bool success = addActivityPresenter.buttonAddActivityClickEvent();
            if (success)
            {
                this.Close();
            }

            
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
        public void setCustomRewardTemplateList(string[] rewardNames)
        {
            comboBoxCustomActivityRewardsRequired.DataSource = rewardNames;
        }

        public void setAdditionTemplateList(string[] additionNames)
        {
            comboBoxAdditions.DataSource = additionNames;
        }

        public void setCustomAdditionTemplateList(string[] additionNames)
        {
            comboBoxCustomActivityAdditions.DataSource = additionNames;
        }

        private void comboBoxSelectActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            addActivityPresenter.comboBoxSelectActivityChangedEvent();
        }

        private void comboBoxRewardsRequired_SelectedIndexChanged(object sender, EventArgs e)
        {
            addActivityPresenter.comboBoxRewardsRequiredChangedEvent();
        }

        private void comboBoxAdditions_SelectedIndexChanged(object sender, EventArgs e)
        {
            addActivityPresenter.comboBoxAdditionsRequiredChangedEvent();
        }
    }
}
