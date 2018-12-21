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
        [BsonElement("_id")]
        [BsonIgnoreIfNull]
        public ObjectId thingId { get; set; }

        [BsonIgnoreIfNull]
        public bool receiveTokenActive { get; set; }

        [BsonIgnoreIfNull]
        public string receiveToken { get; set; }

        [BsonIgnoreIfNull]
        public bool sendTokenActive { get; set; }

        [BsonIgnoreIfNull]
        public string sendToken { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfNull]
        public ObjectId owner { get; set; }

        [BsonIgnoreIfNull]
        public string thingsDesc { get; set; }

        [BsonIgnoreIfNull]
        public string thingsName { get; set; }

        [BsonIgnoreIfNull]
        public DateTime created { get; set; }

        [BsonIgnoreIfNull]
        public int refresh { get; set; }

        [BsonIgnoreIfNull]
        public string thingsPermission { get; set; }

        [BsonIgnoreIfNull]
        public int __v { get; set; }

        [BsonIgnoreIfNull]
        public string thingsData { get; set; }

        [BsonIgnoreIfNull]
        public DateTime thingsDataUpdate { get; set; }

        [BsonIgnoreIfNull]
        public long messageCount { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfNull]
        public ObjectId configGroupId { get; set; }

        [BsonIgnoreIfNull]
        public List<string> routeUrl { get; set; }

        [BsonIgnoreIfNull]
        public string connectName { get; set; }

        [BsonIgnoreIfNull]
        public string connectNameHash { get; set; }

        [BsonIgnoreIfNull]
        public DateTime connectTime { get; set; }
    }
    public class configGroup
    {
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfNull]
        public ObjectId _id { get; set; }

        [BsonIgnoreIfNull]
        public List<string> routeUrl { get; set; }
    }

}
