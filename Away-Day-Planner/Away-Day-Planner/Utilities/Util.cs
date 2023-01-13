﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Utilities
{
    internal class Util
    {
        public static void Print(string x, string name) {Console.WriteLine(name+" : "+x);}
        public static void Debug_Print<T>(T x) { if(AppSettings.Instance.VERBOSE) Console.WriteLine(x);}
        public static void Print<T>(T x, string tag) { Console.WriteLine(tag + " : " + x); }
    }
}
