using MongoDB.Driver;
using NetCoreAPIs_Template.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Utilities.MongoDB
{
    public static class MongoDBUtil
    {
        public static UpdateOptions options
        {
            get { return new UpdateOptions { IsUpsert = false }; }
        }

        public static IMongoCollection<things> _Things
        {
            get { return MongoDBHandle.Mongodb.GetCollection<things>(MongoDBCollectionName.things); }
        }

        public static IMongoCollection<user> _User
        {
            get { return MongoDBHandle.Mongodb.GetCollection<user>(MongoDBCollectionName.user); }
        }

        public static IMongoCollection<configgroups> _Configgroups
        {
            get { return MongoDBHandle.Mongodb.GetCollection<configgroups>(MongoDBCollectionName.configgroups); }
        }

        public static IMongoCollection<thingsdatas> _ThingsDatas
        {
            get { return MongoDBHandle.Mongodb.GetCollection<thingsdatas>(MongoDBCollectionName.thingsdatas); }
        }

    }
}
