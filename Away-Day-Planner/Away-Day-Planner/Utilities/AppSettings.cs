using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Utilities
{
    internal class AppSettings : ApplicationSettingsBase
    {
        private static object _lock = new object();
        private static AppSettings _instance = null;

        public static AppSettings Instance { 
            get { lock (_lock) { if (_instance is null) _instance = new AppSettings(); return _instance; } } 
        }

        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public Boolean VERBOSE { 
            get { lock (_lock) { return (bool)this["VERBOSE"]; }}
            set { lock (_lock) { this["VERBOSE"] = (bool)value; }} 
        }

        [UserScopedSetting()]
        public String DATABASE_STRING
        {
            get { lock (_lock) { return (String)this["DATABASE_STRING"]; }}
            private set { lock (_lock) { this["DATABASE_STRING"] = (String)value; }}
        }
    }
}
