using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonPattern
{
    // Static Singleton Pattern
    public class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private ConfigurationManager() {}
        public static ConfigurationManager Instance 
        { 
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigurationManager();
                }
                return _instance;
            }
        }

        public string GetSetting(string key)
        {
            // Retrieve setting from configuration file
            return "Value for " + key;
        }

    }
}