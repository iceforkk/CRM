using MongoDB.Bson.Serialization;
using SIM.MongoDB;
using System;
using System.Linq;
using System.Reflection;
using WebActivatorEx;
//[assembly: PreApplicationStartMethod(typeof(MongoMapRegister), "Register")]
namespace SIM.MongoDB
{ 
    public partial class MongoMapRegister
    {   
        /// <summary>
        /// 注册所有对 Mongo 模型的映射
        /// </summary>
        public static void Register()
        {
            var registerClasses = Assembly.GetExecutingAssembly().GetTypes()
                .Where(x => x.BaseType != null && x.IsSubclassOf(typeof(BsonClassMap)));

            foreach (var type in registerClasses)
            {
                dynamic classInstance = Activator.CreateInstance(type);
                BsonClassMap.RegisterClassMap(classInstance);
            }
        }
    } 
}
