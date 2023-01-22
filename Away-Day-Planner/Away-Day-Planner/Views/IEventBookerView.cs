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
using Away_Day_Planner.Presenters;

namespace Away_Day_Planner.Views
{
    public interface IEventBookerView
    {
        void register(EventBookerPresenter eventBookerPresenter);
        void setActivityList(String[] activityListNames);
        string pageTitle { get; set; }
        string clientDistance { get; set; }
        string totalPrice { get; set; }
        DateTime selectedDate { get; set; }
        int noOfAttendees { get; }
        string ErrorDate { get; set; }
        string SuccessFailMessage { get; set; }
    }
}
