﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.EventBooker
{
    class Department : IDepartment
    {
        private int Id;
        public int id { get => Id; }

        private string Name;
        public string name { get => Name; set => Name = value; }
    }
}
