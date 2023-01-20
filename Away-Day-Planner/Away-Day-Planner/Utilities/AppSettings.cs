using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Utilities
{
    // Settings that are available globally within the application
    public class AppSettings : ApplicationSettingsBase
    {
        // Thread safety implementation
        private static object _lock = new object();
        // Singleton design pattern, only one settings instance is needed
        private static AppSettings _instance = null;
        public static AppSettings Instance { 
            get { lock (_lock) { if (_instance is null) _instance = new AppSettings(); return _instance; } } 
        }

        // Setting that is scope to the user profile the application is running on
        // Allows for storing if the app should be verbose in its output
        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool VERBOSE { 
            get { lock (_lock) { return (bool)this["VERBOSE"]; }}
            set { lock (_lock) { this["VERBOSE"] = (bool)value; }} 
        }

        // Setting that defines if it should log additional features
        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool LOGGING
        {
            get { lock (_lock) { return (bool)this["LOGGING"]; }}
            set { lock (_lock) { this["LOGGING"] = (bool)value; }}
        }
    }
}
