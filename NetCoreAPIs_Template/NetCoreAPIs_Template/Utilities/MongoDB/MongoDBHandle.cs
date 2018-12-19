using MongoDB.Driver;
using NetCoreAPIs_Template.AppSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Utilities.MongoDB
{
    public static class MongoDBHandle
    {
        public static IMongoDatabase _database;
        public static MongoClient _client;

        public static IMongoDatabase Mongodb
        {
            get
            {
                MongoCredential credential = MongoCredential.CreateCredential(SettingsHelper.MongoDB.MongoName, SettingsHelper.MongoDB.MongoUser, SettingsHelper.MongoDB.MongoPass);
                MongoClientSettings settings = new MongoClientSettings
                {
                    // Set Database Server IP Address And Port
                    Server = new MongoServerAddress(SettingsHelper.MongoDB.MongoIP, SettingsHelper.MongoDB.MongoPort),

                    // Giving 60 seconds for a MongoDB server to be up before we throw
                    ServerSelectionTimeout = TimeSpan.FromSeconds(SettingsHelper.MongoDB.MongoSelectionTimeout),

                    // Set DatabaseName, UserName, Password
                    Credentials = new[] { credential },

                    ConnectTimeout = TimeSpan.FromSeconds(SettingsHelper.MongoDB.MongoTimeout),
                    UseSsl = false
                };
                //if (Configuration.GetServerType(Configuration.MyServer) == Enums.ServerTypes.ApiCloudServer)
                //    settings.Credentials = new[] { credential };
                //_client = new MongoClient(MongoDBConnection);
                _client = new MongoClient(settings);
                _database = _client.GetDatabase(SettingsHelper.MongoDB.MongoName);
                return _database;
            }
        }
    }
}
