using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Utilities
{
    // Provides static dictionaries that allow for easier use of exceptions that might arise multiple times
    public class ErrorList
    {
        public static readonly Dictionary<string, Exception> Errors = new Dictionary<string, Exception>()
        {
            {"Null", new Exception("Oops, Null Object")}
        };
        public static readonly Dictionary<string, Exception> DatabaseErrors = new Dictionary<string, Exception>()
        {
            {"InvalidType", new Exception("Oops, there was an unknown model type")},
            {"TypeMismatch", new Exception("Oops, you cannot update an entity with a different object")},
            {"NegativeID", new Exception("Oops, an ID cannot be negative")},
            {"InvalidRange", new Exception("Oops, Upper range cannot be lower than lower range")},
            {"NullEntity", new Exception("Object provided was null")},
            {"NoID", new Exception("Object does not contain id field (Case sensitive)")},
        };
        public static readonly Dictionary<string, Exception> EventErrors = new Dictionary<string, Exception>()
        {
            {"15Days", new Exception("Cannot Cancel within 15 days of event date!")}
        };
    }
}
