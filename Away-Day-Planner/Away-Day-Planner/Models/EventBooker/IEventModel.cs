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
        void addNewEvent();
        void addNewActivity(String name, Decimal price, bool facilitatorRequired, int eventFK);
        void addNewReward(String name, Decimal price, int activityFK);
        void addNewAddition(String name, Decimal price, int activityFK);
        Event[] getAllEvents();
        Date[] getAllStoredDates();
        BookedFacilitatorTeamDate[] getAllBookedFacilitatorTeamDates();
        int getCurrentEventId();
        int getCurrentActivityId();
        IActivity[] getAllActivities();
        Addition[] getActivityAdditions(int activityId);
        Reward[] getActivityRewards(int activityId);
        void updateEvent(int eventId, Event newEvent);
        void addNewDate(DateTime eventDate, int newEventId);
    }
}
