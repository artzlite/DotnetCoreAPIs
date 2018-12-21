using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Entities
{
    [BsonIgnoreExtraElements]
    public class user
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        [BsonIgnoreIfNull]
        public ObjectId userId { get; set; }

        [BsonIgnoreIfNull]
        public string salt { get; set; }

        [BsonIgnoreIfNull]
        public string displayName { get; set; }

        [BsonIgnoreIfNull]
        public string provider { get; set; }

        [BsonIgnoreIfNull]
        public string username { get; set; }

        [BsonIgnoreIfNull]
        public DateTime created { get; set; }

        [BsonIgnoreIfNull]
        public List<string> roles { get; set; }

        [BsonIgnoreIfNull]
        public string profileImageURL { get; set; }

        [BsonIgnoreIfNull]
        public string password { get; set; }

        [BsonIgnoreIfNull]
        public string email { get; set; }

        [BsonIgnoreIfNull]
        public string lastName { get; set; }

        [BsonIgnoreIfNull]
        public string firstName { get; set; }

        [BsonIgnoreIfNull]
        public bool newUser { get; set; }

        [BsonIgnoreIfNull]
        public int __v { get; set; }
    }
}
