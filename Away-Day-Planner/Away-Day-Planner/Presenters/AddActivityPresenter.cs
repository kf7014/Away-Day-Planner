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
            ActivityTemplate[] activityTemplates = eventModel.getActivityTemplates();
            String[] activityNames = new string[activityTemplates.Length];
            
            for(int i=0; i<activityTemplates.Length; i++)
            {
                activityNames[i] = activityTemplates[i].name;
                Console.WriteLine("Name " + activityTemplates[i].name);
            }

            addActivityView.setActivityTemplateList(activityNames);

            //Populate rewards dropdown
            RewardTemplate[] rewardTemplates = eventModel.getRewardTemplates();
            String[] rewardNames = new string[rewardTemplates.Length];
            
            for (int i = 0; i < rewardTemplates.Length; i++)
            {
                rewardNames[i] = rewardTemplates[i].name;
                Console.WriteLine("Name " + rewardTemplates[i].name);
            }

            addActivityView.setRewardTemplateList(rewardNames);
        }
    }
}
