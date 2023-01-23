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
using Away_Day_Planner.Presenters;

namespace Away_Day_Planner.Views
{
    public interface ICreateClientView
    {
        //Register view to presenter
        void register(CreateClientPresenter createClientPresenter);
        String ClientName { get; set; }
        decimal NumberOfHoursAway { get; set; }
        bool HadClientDispute { get; set; }
        String ErrorMessageName { get; set; }
        String ErrorMessageDistanceAway { get; set; }
        String ErrorMessageDispute { get; set; }
    }
}
