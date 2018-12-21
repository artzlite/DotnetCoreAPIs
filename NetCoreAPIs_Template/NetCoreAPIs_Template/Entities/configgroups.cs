using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Entities
{
    public class configgroups
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        [BsonIgnoreIfNull]
        public ObjectId configgroupId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfNull]
        public ObjectId owner { get; set; }

        [BsonIgnoreIfNull]
        public string configName { get; set; }

        [BsonIgnoreIfNull]
        public Dictionary<string, string> config { get; set; }

        [BsonIgnoreIfNull]
        public List<string> routeUrl { get; set; }

        [BsonIgnoreIfNull]
        public DateTime created { get; set; }

        [BsonIgnoreIfNull]
        public int __v { get; set; }
    }
}
