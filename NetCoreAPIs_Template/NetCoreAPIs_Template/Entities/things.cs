using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Entities
{
    [BsonIgnoreExtraElements]
    public class things
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfNull]
        public ObjectId _id { get; set; }

        public bool receiveTokenActive { get; set; }
        public string receiveToken { get; set; }
        public bool sendTokenActive { get; set; }
        public string sendToken { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfNull]
        public ObjectId owner { get; set; }
        public string thingsDesc { get; set; }
        public string thingsName { get; set; }
        public DateTime created { get; set; }
        public int refresh { get; set; }
        public string thingsPermission { get; set; }
        public int __v { get; set; }
        public string thingsData { get; set; }
        public DateTime thingsDataUpdate { get; set; }
        public long messageCount { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfNull]
        public ObjectId configGroupId { get; set; }
        public List<string> routeUrl { get; set; }
        public string connectName { get; set; }
        public string connectNameHash { get; set; }
        public DateTime connectTime { get; set; }
    }
    public class configGroup
    {
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfNull]
        public ObjectId _id { get; set; }
        public List<string> routeUrl { get; set; }
    }

}
