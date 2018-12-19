using Microsoft.Extensions.Options;
using NetCoreAPIs_Template.AppSettings.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.AppSettings
{
    public class SettingsHelper
    {
        private static AppSettingsMapping _settings;
        public static void Initial(IOptions<AppSettingsMapping> settings)
        {
            _settings = settings.Value;
        }

        public static MongoDBMapping MongoDB
        {
            get
            {
                return _settings.MongoDB;
            }
        }


    }
}
