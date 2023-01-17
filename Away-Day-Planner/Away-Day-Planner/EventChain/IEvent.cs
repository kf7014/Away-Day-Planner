﻿using Away_Day_Planner.EventChain.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.EventChain
{
    public enum EVENT_STATE
    {
        BASE, PRELIMINARY, EVENT, PAYMENT, CANCELLED, ARCHIVED
    }
    public interface IEvent
    {
        EVENT_STATE EventState { get; set; }
    }
}
