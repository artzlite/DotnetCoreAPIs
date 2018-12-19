using MongoDB.Driver;
using NetCoreAPIs_Template.Entities;
using NetCoreAPIs_Template.Repositories;
using NetCoreAPIs_Template.Repositories.Interfaces;
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

        public static IThingRepo _Things
        {
            get { return new ThingsRepo(); }
            //get { return MongoDBHandle.Mongodb.GetCollection<things>("things"); }
        }
    }
}
