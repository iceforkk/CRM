using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Configuration;
using System.Linq;

namespace SIM.MongoDB
{
    public class MongoDbHandler<T> where T : IEntity
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["mongo"].ConnectionString;
        private string databaseName = ConfigurationManager.AppSettings["mongodb"];
        public IMongoCollection<T> Collection { get; private set; }
        public MongoDbHandler()
        {
            var mongoClient = new MongoClient(connectionString);
            var mongoDb = mongoClient.GetDatabase(databaseName);  
                //不存在则创建
           this.Collection = mongoDb.GetCollection<T>(typeof(T).Name);
        }
    } 
}
