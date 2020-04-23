using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIM.MongoDB;

namespace SIM.Domain
{
    public interface IUserRepository: IRepository<User,Guid>
    {
    }
}
