using MongoDB.Bson;
using NetCoreAPIs_Template.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Repositories.Interfaces
{
    public interface IThingRepo
    {
        void Add(things entity);
        //IEnumerable<things> GetList();
        things FindOne(ObjectId _id);
        //things Remove(string key);
        //void Update(things item);
    }
}
