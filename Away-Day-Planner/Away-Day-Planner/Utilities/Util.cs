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

namespace Away_Day_Planner.Utilities
{
    public class Util
    {
        public static void Print(string name) { Console.WriteLine(name); } // Prints with a tag
        public static void Print_Tag(string x, string name) {Console.WriteLine(name+" : "+x);} // Prints with a tag
        public static void Debug_Print<T>(T x) { if(AppSettings.Instance.VERBOSE) Console.WriteLine(x);} // Prints with a tag if verbose is true
        public static void Print<T>(T x, string tag) { Console.WriteLine(tag + " : " + x); } // Prints with a generic
    }
}
