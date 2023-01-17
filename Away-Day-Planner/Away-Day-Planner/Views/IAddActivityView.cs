using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Views
{
    public interface IAddActivityView
    {
        //Register view to presenter
        void register(AddActivityPresenter addActivityPresenter);
        void setActivityTemplateList(string[] activityNames);
        void setRewardTemplateList(string[] rewardNames);
        void setCustomRewardTemplateList(string[] rewardNames);
        void setAdditionTemplateList(string[] additionNames);
        void setCustomAdditionTemplateList(string[] additionNames);
        int selectedActivity { set; get; }
        int selectedReward { set; get; }
        int selectedAddition { set; get; }
        String totalPrice { set; get; }
    }
}
