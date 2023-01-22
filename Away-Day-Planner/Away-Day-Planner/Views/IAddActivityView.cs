/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009595
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
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
        String selectedActivityName { set; get; }
        String selectedRewardName { set; get; }
        String selectedAdditionName { set; get; }
        String totalPrice { set; get; }
        bool facilitatorRequired { set; get; }
        string selectedCustomActivityName { set; get; }
        bool facilitatorRequiredCustom { set; get; }
        string totalCustomPrice { set; get; }
        string ErrorSelectActivity { set; get; }
        string ErrorRewards { set; get; }
        string ErrorAdditions { set; get; }
    }
}
