﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Presenters;

namespace Away_Day_Planner.Views
{
    public interface IRegisterView
    {
        void register(RegisterUserPresenter registerUserPresenter);
        //getters and setters
        String firstName { get; set; }
        String lastName { get; set; }
        String username { get; set; }
        String userEmail { get; set; }
        String userPassword { get; set; }
        String userRole { get; set; }
        //error messages
        String ErrorMessageFirstName { get; set; }
        String ErrorMessageLastName { get; set; }
        String ErrorMessageUsername { get; set; }
        String ErrorMessageEmail { get; set; }
        String ErrorMessagePassword { get; set; }
        String ErrorMessageRole { get; set; }
      
    }
}
