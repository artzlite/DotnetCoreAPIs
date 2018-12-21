using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Entities
{
    [BsonIgnoreExtraElements]
    public class thingsdatas
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        [BsonIgnoreIfNull]
        public ObjectId thingdataId { get; set; }

        [BsonIgnoreIfNull]
        public string data { get; set; }

        [BsonIgnoreIfNull]
        public string sendToken { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfNull]
        public ObjectId thingsId { get; set; }

        [BsonIgnoreIfNull]
        public DateTime created { get; set; }

        [BsonIgnoreIfNull]
        public int __v { get; set; }
    }
}
