using MongoDB.Bson;
using MongoDB.Driver;
using NetCoreAPIs_Template.Entities;
using NetCoreAPIs_Template.Repositories.Interfaces;
using NetCoreAPIs_Template.Utilities.MongoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Repositories
{
    public class ThingsRepo : IThingRepo
    {
        private readonly string _collectionName = "things";

        public void Create(things entity)
        {
            MongoDBHandle.Mongodb.GetCollection<things>(_collectionName).InsertOne(entity);
        }
        public things FindOne(ObjectId _id)
        {
            return MongoDBHandle.Mongodb.GetCollection<things>(_collectionName).Find(u => u._id == _id).FirstOrDefault();
        }
    }
}
