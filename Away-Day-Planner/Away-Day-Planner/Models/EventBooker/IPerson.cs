﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.EventBooker
{
    public interface IPerson
    {
        int id { get; }
        String firstName { set; get; }
        String lastName { set; get; }
        String emailAddress { set; get; }
    }
}