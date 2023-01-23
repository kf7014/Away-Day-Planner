/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009505
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
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

        //Populate list of preset activities that can be chosen from
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

        //Populate list of preset rewards that can be chosen from
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

        //Populate list of preset additions that can be chosen from
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

        //Update current price of activity to reflect selected options
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

            if(selectedReward != null && selectedAddition != null)
            {
                decimal totalCustomPrice = selectedReward.price + selectedAddition.price;
                addActivityView.totalCustomPrice = totalCustomPrice.ToString();
            }
        }

        //Runs when Add Activity button is pressed
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

            //VALIDATION
            //validate activity selection
            if(activityTemplate == null)
            {
                addActivityView.ErrorSelectActivity = "Activity name cannot be null";
                validationErrors = true;
            } 
            else if (activityTemplate.name.Length < 2)
            {
                addActivityView.ErrorSelectActivity = "Activity name must be longer than 2 characters";
                validationErrors = true;
            } 
            else if (activityTemplate.name.Length > 50)
            {
                addActivityView.ErrorSelectActivity = "Activity name must be shorter than 50 characters";
                validationErrors = true;
            }
            else if (activityTemplate.name == null)
            {
                addActivityView.ErrorSelectActivity = "Activity name cannot be null";
                validationErrors = true;
            }

            //validate reward selection
            if (rewardTemplate == null)
            {
                addActivityView.ErrorRewards = "Reward name cannot be null";
                validationErrors = true;
            } 
            else if (rewardTemplate.name.Length < 2)
            {
                addActivityView.ErrorRewards = "Reward name must be longer than 2 characters";
                validationErrors = true;
            }
            else if (rewardTemplate.name.Length > 50)
            {
                addActivityView.ErrorRewards = "Reward name must be shorter than 50 characters";
                validationErrors = true;
            }
            else if (rewardTemplate.name == null)
            {
                addActivityView.ErrorRewards = "Reward name cannot be null";
                validationErrors = true;
            }

            //validate addition selection
            if (additionTemplate == null)
            {
                addActivityView.ErrorAdditions = "Addition name cannot be null";
                validationErrors = true;
            }
            else if (additionTemplate.name.Length < 2)
            {
                addActivityView.ErrorAdditions = "Addition name must be longer than 2 characters";
                validationErrors = true;
            }
            else if (additionTemplate.name.Length > 50)
            {
                addActivityView.ErrorAdditions = "Addition name must be shorter than 50 characters";
                validationErrors = true;
            }
            else if (additionTemplate.name == null)
            {
                addActivityView.ErrorAdditions = "Addition name cannot be null";
                validationErrors = true;
            }

            if (validationErrors == false)
            {
                //Get ID of event activity is being added to
                int eventId = eventModel.getCurrentEventId();

                //Add new activity
                eventModel.addNewActivity(activityTemplate.name, activityTemplate.price, facilitatorRequired, eventId);

                //Get ID of activity rewards and additions will be added to
                int currentActivity = eventModel.getCurrentActivityId();

                //Add rewards and additions to their respective tables, linked to the activity
                eventModel.addNewReward(rewardTemplate.name, rewardTemplate.price, currentActivity);
                eventModel.addNewAddition(additionTemplate.name, additionTemplate.price, currentActivity);

                return true;
            } else
            {
                return false;
            }
        }

        public bool buttonAddCustomActivityClickEvent()
        {
            int selectedRewardId = addActivityView.selectedReward;
            int selectedAdditionId = addActivityView.selectedAddition;

            String customActivityName = addActivityView.selectedCustomActivityName;
            bool facilitatorRequired = addActivityView.facilitatorRequiredCustom;
            Decimal customActivityPrice = 0;
            RewardTemplate rewardTemplate = eventModel.getRewardTemplate(selectedRewardId + 1);
            AdditionTemplate additionTemplate = eventModel.getAdditionTemplate(selectedAdditionId + 1);


            bool validationErrors = false;

            //VALIDATION
            //validate custom activity name
            if (customActivityName.Length < 2)
            {
                addActivityView.ErrorSelectActivity = "Custom Activity name must be longer than 2 characters";
                validationErrors = true;
            }
            else if (customActivityName.Length > 50)
            {
                addActivityView.ErrorSelectActivity = "Custom Activity name must be shorter than 50 characters";
                validationErrors = true;
            }
            else if (customActivityName == null)
            {
                addActivityView.ErrorSelectActivity = "Custom Activity name cannot be null";
                validationErrors = true;
            }

            //validate reward selection
            if (rewardTemplate == null)
            {
                addActivityView.ErrorRewards = "Reward name cannot be null";
                validationErrors = true;
            } else if (rewardTemplate.name.Length < 2)
            {
                addActivityView.ErrorRewards = "Reward name must be longer than 2 characters";
                validationErrors = true;
            }
            else if (rewardTemplate.name.Length > 50)
            {
                addActivityView.ErrorRewards = "Reward name must be shorter than 50 characters";
                validationErrors = true;
            }
            else if (rewardTemplate.name == null)
            {
                addActivityView.ErrorRewards = "Reward name cannot be null";
                validationErrors = true;
            }

            //validate addition selection
            if (additionTemplate == null)
            {
                addActivityView.ErrorAdditions = "Addition name cannot be null";
                validationErrors = true;
            }
            else if (additionTemplate.name.Length < 2)
            {
                addActivityView.ErrorAdditions = "Addition name must be longer than 2 characters";
                validationErrors = true;
            }
            else if (additionTemplate.name.Length > 50)
            {
                addActivityView.ErrorAdditions = "Addition name must be shorter than 50 characters";
                validationErrors = true;
            }
            else if (additionTemplate.name == null)
            {
                addActivityView.ErrorAdditions = "Addition name cannot be null";
                validationErrors = true;
            }


            if (validationErrors == false)
            {
                //Get ID of event activity is being added to
                int eventId = eventModel.getCurrentEventId();

                //Add new activity
                eventModel.addNewActivity(customActivityName, customActivityPrice, facilitatorRequired, eventId);

                //Get ID of activity rewards and additions will be added to
                int currentActivity = eventModel.getCurrentActivityId();

                //Add rewards and additions to their respective tables, linked to the activity
                eventModel.addNewReward(rewardTemplate.name, rewardTemplate.price, currentActivity);
                eventModel.addNewAddition(additionTemplate.name, additionTemplate.price, currentActivity);

                return true;
            }  else
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
