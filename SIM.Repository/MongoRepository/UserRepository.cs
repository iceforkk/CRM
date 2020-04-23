using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIM.Domain;
using SIM.MongoDB;

namespace SIM.Repository.MongoRepository
{
    public class UserRepository: BaseMongoRepository<User,Guid>, IUserRepository
    {
       
    }
}
