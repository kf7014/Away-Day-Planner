﻿using System;
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
    }
}
