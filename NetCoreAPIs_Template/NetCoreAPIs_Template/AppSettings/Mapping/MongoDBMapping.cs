using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.AppSettings.Mapping
{
    public class MongoDBMapping
    {
        public string MongoName { get; set; }
        public string MongoIP { get; set; }
        public int MongoPort { get; set; }
        public int MongoTimeout { get; set; }
        public int MongoSelectionTimeout { get; set; }
        public string MongoUser { get; set; }
        public string MongoPass { get; set; }
    }
}
