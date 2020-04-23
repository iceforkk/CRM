using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;

namespace SIM.MongoDB
{
    public abstract class BaseMongoRepository<TEntity,TKey> : IRepository<TEntity,TKey> 
        where TEntity : EntityBase<TKey>
    {
        private MongoDbHandler<TEntity> MongoDbHandler;

        public BaseMongoRepository()
        {
            this.MongoDbHandler = new MongoDbHandler<TEntity>();  
            BsonSerializer.RegisterSerializer(typeof(DateTime), new DateTimeSerializer(DateTimeKind.Local));
        } 
        public virtual async Task<TEntity> GetByIdAsync(TKey id)
        {
            return await MongoDbHandler.Collection.Find(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }

        public virtual TEntity SaveAsync(Expression<Func<TEntity, bool>> predicate,TEntity entity)
        { 
            var update =new UpdateOptions{IsUpsert=true};
             MongoDbHandler.Collection.ReplaceOne(
             predicate,
                entity,
                update);

            return entity;
        }

        public void Add(TEntity entity) 
        { 
            MongoDbHandler.Collection.InsertOne(entity);
        }
        public virtual async Task DeleteAsync(TKey id)
        {
            await MongoDbHandler.Collection.DeleteOneAsync(x => x.Id.Equals(id));
        }

        public virtual async Task<List<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await MongoDbHandler.Collection.Find(predicate).ToListAsync();
        }

        public List<TEntity> FindList(Expression<Func<TEntity, bool>> predicate)  
        {
            return MongoDbHandler.Collection.Find(predicate).ToList();
        }
        public bool Updat(TEntity entity) 
        { 
            var updateDefinitionList = entity.GetUpdateDefinition();

            var result = MongoDbHandler.Collection.UpdateOne(a => a.Id.Equals(entity.Id), updateDefinitionList);

            return result.ModifiedCount > 0;
        }
    }
}
