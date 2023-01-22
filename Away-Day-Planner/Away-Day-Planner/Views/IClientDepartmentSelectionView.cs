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
    public interface IClientDepartmentSelectionView
    {
        //Register view to presenter
        void register(ClientDepartmentSelectionPresenter clientDepartmentSelectionPresenter);
        void setClientList(string[] names);
        void setDepartmentList(string[] names);
        int selectedClientIndex { get; set; }
        int selectedDepartmentIndex { get; set; }
        String ErrorConfirmSelection { get; set; }
    }
}
