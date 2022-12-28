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
        public bool VERBOSE { 
            get { lock (_lock) { return (bool)this["VERBOSE"]; }}
            set { lock (_lock) { this["VERBOSE"] = (bool)value; }} 
        }

        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool LOGGING
        {
            get { lock (_lock) { return (bool)this["LOGGING"]; }}
            set { lock (_lock) { this["LOGGING"] = (bool)value; }}
        }
    }
}
