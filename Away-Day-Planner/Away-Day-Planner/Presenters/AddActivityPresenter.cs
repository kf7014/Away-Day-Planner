using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;
using Away_Day_Planner.Models.EventBooker;

namespace Away_Day_Planner.Views
{
    public class AddActivityPresenter
    {
        private IAddActivityView addActivityView;
        private IEventModel eventModel;

        public AddActivityPresenter(IAddActivityView addActivityView, IEventModel eventModel)
        {
            this.addActivityView = addActivityView;
            this.eventModel = eventModel;
            addActivityView.register(this);
            populateScreen();
        }

        private void populateScreen()
        {
            //Populate template activities dropdown
            populateTemplateActivities();

            //Populate rewards dropdown
            populateRewardsDropdown();

            //Populate additions dropdown
            populateAdditionsDropdown();

            //Update price field on form with choices' total price
            updateActivityPricing();
        }

        private void populateTemplateActivities()
        {
            ActivityTemplate[] activityTemplates = eventModel.getActivityTemplates();
            String[] activityNames = new string[activityTemplates.Length];

            for (int i = 0; i < activityTemplates.Length; i++)
            {
                activityNames[i] = activityTemplates[i].name;
            }

            addActivityView.setActivityTemplateList(activityNames);
        }

        private void populateRewardsDropdown()
        {
            RewardTemplate[] rewardTemplates = eventModel.getRewardTemplates();
            String[] rewardNames = new string[rewardTemplates.Length];

            for (int i = 0; i < rewardTemplates.Length; i++)
            {
                rewardNames[i] = rewardTemplates[i].name;
            }

            addActivityView.setRewardTemplateList(rewardNames);
            addActivityView.setCustomRewardTemplateList(rewardNames);
        }

        private void populateAdditionsDropdown()
        {
            AdditionTemplate[] additionTemplates = eventModel.getAdditionTemplates();
            String[] additionNames = new string[additionTemplates.Length];

            for (int i = 0; i < additionTemplates.Length; i++)
            {
                additionNames[i] = additionTemplates[i].name;
            }

            addActivityView.setAdditionTemplateList(additionNames);
            addActivityView.setCustomAdditionTemplateList(additionNames);
        }

        public void updateActivityPricing()
        {
            int activityId = addActivityView.selectedActivity;
            int rewardId = addActivityView.selectedReward;
            int additionId = addActivityView.selectedAddition;

            ActivityTemplate selectedActivity = eventModel.getActivityTemplate(activityId + 1);
            RewardTemplate selectedReward = eventModel.getRewardTemplate(rewardId + 1);
            AdditionTemplate selectedAddition = eventModel.getAdditionTemplate(additionId + 1);

            if(selectedActivity != null && selectedReward != null && selectedAddition != null)
            {
                decimal totalPrice = (selectedActivity.price + selectedReward.price + selectedAddition.price);
                addActivityView.totalPrice = totalPrice.ToString();
            }


        }

        public bool buttonAddActivityClickEvent()
        {
            int selectedActivityId = addActivityView.selectedActivity;
            int selectedRewardId = addActivityView.selectedReward;
            int selectedAdditionId = addActivityView.selectedAddition;

            ActivityTemplate activityTemplate = eventModel.getActivityTemplate(selectedActivityId + 1);
            RewardTemplate rewardTemplate = eventModel.getRewardTemplate(selectedRewardId + 1);
            AdditionTemplate additionTemplate = eventModel.getAdditionTemplate(selectedAdditionId + 1);

            bool facilitatorRequired = addActivityView.facilitatorRequired;

            bool validationErrors = false;

            if(validationErrors == false)
            {
                int eventId = eventModel.getCurrentEventId();

                //TODO: Add new activity

                eventModel.addNewActivity(activityTemplate.name, activityTemplate.price, facilitatorRequired, eventId);

                int currentActivity = eventModel.getCurrentActivityId();

                eventModel.addNewReward(rewardTemplate.name, rewardTemplate.price, currentActivity);
                eventModel.addNewAddition(additionTemplate.name, additionTemplate.price, currentActivity);

                return true;
            } else
            {
                return false;
            }
        }

        public void comboBoxSelectActivityChangedEvent()
        {
            updateActivityPricing();
        }

        public void comboBoxRewardsRequiredChangedEvent()
        {
            updateActivityPricing();
        }

        public void comboBoxAdditionsRequiredChangedEvent()
        {
            updateActivityPricing();
        }
    }
}
