using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers; 

namespace SIM.MongoDB
{
    public partial class UserMap : BsonClassMap
    {
        public UserMap()
            : base(typeof(User))
        {
            this.Reset();
            this.AutoMap();
            //映射的 Collection 名称
            //默认为类名 即 typeof(Tclass).Name
            this.SetDiscriminator("User");
            this.MapProperty("Gender").SetSerializer(new EnumSerializer<Gender>(BsonType.String));
            //这里不仅仅可以映射枚举，还可以映射字段名，
            //主要应用在数据库中已经存在数据的情况下，或者想改名
            //例如：字段 RegisterTime 映射为数据库中的 AddTime
            //this.MapProperty("RegisterTime").SetElementName("AddTime");
        }
    } 
}
