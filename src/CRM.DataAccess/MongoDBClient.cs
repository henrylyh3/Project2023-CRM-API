using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Events;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DataAccess.Repositories
{
    public class MongoDBClient
    {
        private static MongoClient _mongoClient;
        private static IMongoDatabase _mongoDb;

        public MongoDBClient(IConfiguration configuration)
        {
            var clientSettings = MongoClientSettings.FromConnectionString(configuration["Database:ConnectionString"]);


            _mongoClient = new MongoClient(clientSettings);

            _mongoDb = _mongoClient.GetDatabase(configuration["Database:DatabaseName"]);
        }

        public IMongoDatabase MongoDb => _mongoDb;
    }
}
