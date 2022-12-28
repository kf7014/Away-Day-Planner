using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Utilities
{
    internal class ArgumentParser
    {
        private readonly ArrayList argument_array = new ArrayList();
        private enum VALID_ARG
        {
            VERBOSE
        }
        private readonly IDictionary<string, VALID_ARG> argument_dictionary = new Dictionary<string, VALID_ARG>()
        {
            {"D", VALID_ARG.VERBOSE},
            {"DEBUG", VALID_ARG.VERBOSE},
            {"V", VALID_ARG.VERBOSE},
            {"VERBOSE", VALID_ARG.VERBOSE},
        };

        private AppSettings app_settings = AppSettings.Instance;
        public ArgumentParser(string[] argument_array) 
        {
            this.ParseArguments(argument_array);
        }
        private void ParseArguments(string[] arr)
        {
            foreach (string arg in arr) 
            {
                string[] x = arg.Split('-');
                string y = x[x.Length - 1].ToUpper();
                if (key_exists(y)) 
                {
                    VALID_ARG a = argument_dictionary[y];
                    if (array_contains(a)) continue;
                    else argument_array.Add(a);
                }
            }
        }
        private bool key_exists(string key)
        {
            return argument_dictionary.ContainsKey(key);
        }
        private bool array_contains(VALID_ARG x) 
        {
            return argument_array.Contains(x);
        }

        public IList GetArguments()
        {
            return argument_array;
        }
        public string ArgumentsAsString() 
        {
            if (argument_array.Count is 0) return "Empty";
            else return String.Join(", ", argument_array.ToArray());
        }
        public void SetSettings()
        {
            foreach(VALID_ARG arg in argument_array)
            {
                switch (arg)
                {
                    case VALID_ARG.VERBOSE: AppSettings.Instance.VERBOSE = true; break;
                    default: return;
                }
            }
        }
    }
}
