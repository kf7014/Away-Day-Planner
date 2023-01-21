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


        public string selectedCustomActivityName
        {
            get { return textBoxCustomActivityName.Text; }
            set { textBoxCustomActivityName.Text = value; }
        }
        public bool facilitatorRequiredCustom
        {
            get { return checkBoxCustomActivityFacilitator.Checked; }
            set { checkBoxCustomActivityFacilitator.Checked = value; }
        }
        public string totalCustomPrice
        {
            get { return labelCustomPriceValue.Text; }
            set { labelCustomPriceValue.Text = value; }
        }
        public string ErrorSelectActivity
        {
            get { return labelErrorSelectActivity.Text; }
            set { labelErrorSelectActivity.Text = value; }
        }
        public string ErrorFacilitatorRequired
        {
            get { return labelErrorFacilitatorRequired.Text; }
            set { labelErrorFacilitatorRequired.Text = value; }
        }
        public string ErrorRewards
        {
            get { return labelErrorRewardsRequired.Text; }
            set { labelErrorRewardsRequired.Text = value; }
        }
        public string ErrorAdditions
        {
            get { return labelErrorAdditions.Text; }
            set { labelErrorAdditions.Text = value; }
        }
            


        private void buttonAddActivity_Click(object sender, EventArgs e)
        {
            bool success = addActivityPresenter.buttonAddActivityClickEvent();
            if (success)
            {
                this.Close();
            }
        }

        private void buttonAddCustomActivity_Click(object sender, EventArgs e)
        {
            bool success = addActivityPresenter.buttonAddCustomActivityClickEvent();
            if (success)
            {
                this.Close();
            }
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
