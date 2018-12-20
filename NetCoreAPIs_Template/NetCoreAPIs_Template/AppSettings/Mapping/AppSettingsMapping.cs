using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.AppSettings.Mapping
{
    public class AppSettingsMapping
    {
        public string Test { get; set; }
        public MongoDBMapping MongoDB { get; set; }
        public JwtMapping Jwt { get; set; }
    }
}
