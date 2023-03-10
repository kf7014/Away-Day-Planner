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
    public interface ILoginView
    {
        
        void register(LoginUserPresenter loginUserPresenter);

        String loginUsername { get; set; }
        String loginPassword { get; set; }

        String LoginErrorMessagePassword { get; set; }
        String LoginErrorMessageUsername { get; set; }
        String LoginErrorInvalidDetails { get; set; }


    }
}
