using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.EventBooker
{
    public interface IEventModel
    {
        IActivity[] getEventActivityList(int eventId);
        int clientId { get; set; }
        int departmentId { get; set; }
        void setParents(int clientId, int departmentId);
        ActivityTemplate[] getActivityTemplates();
        RewardTemplate[] getRewardTemplates();
        AdditionTemplate[] getAdditionTemplates();
        ActivityTemplate getActivityTemplate(int activityId);
        RewardTemplate getRewardTemplate(int rewardId);
        AdditionTemplate getAdditionTemplate(int additionId);
    }
}
