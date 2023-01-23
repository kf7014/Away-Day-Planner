/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009505
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Utilities
{
    // Parses command line argument "app.exe -v -xyz"
    public class ArgumentParser
    {
        public readonly ArrayList argument_array = new ArrayList();

        // Defines what arguments are valid
        public enum VALID_ARG
        {
            VERBOSE,
            LOGGING
        }
        // Defines what command line flags are associated with each valid argument
        private readonly IDictionary<string, VALID_ARG> argument_dictionary = new Dictionary<string, VALID_ARG>()
        {
            {"D", VALID_ARG.VERBOSE},
            {"DEBUG", VALID_ARG.VERBOSE},
            {"V", VALID_ARG.VERBOSE},
            {"VERBOSE", VALID_ARG.VERBOSE},

            {"L", VALID_ARG.LOGGING },
            {"LOG", VALID_ARG.LOGGING },
            {"LOGGING", VALID_ARG.LOGGING }
        };

        public ArgumentParser(string[] argument_array) 
        {
            ParseArguments(argument_array);
        }
        // Parses the arguments from the arg string into an array which can then be interpreted by other methods
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
        // Checks if a command line argument exists in the dictionary
        private bool key_exists(string key)
        {
            return argument_dictionary.ContainsKey(key);
        }
        // Checks if the argument was enabled and stored in the arguments array
        private bool array_contains(VALID_ARG x) 
        {
            return argument_array.Contains(x);
        }
        // Returns the arguments array
        public IList GetArguments()
        {
            return argument_array;
        }
        // Returns the arguments array as a string of its contents
        public string GetArgumentsAsString() 
        {
            if (argument_array.Count is 0) return "Empty";
            else return String.Join(", ", argument_array.ToArray());
        }
        // Applies the relevant settings to the global settings instance if the argument was enabled at command line
        public void SetSettings()
        {
            foreach(VALID_ARG arg in argument_array)
            {
                switch (arg)
                {
                    case VALID_ARG.VERBOSE: AppSettings.Instance.VERBOSE = true; break;
                    case VALID_ARG.LOGGING: AppSettings.Instance.LOGGING = true; break;
                    default: return;
                }
            }
        }
    }
}
