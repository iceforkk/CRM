using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIM.Repository.MongoRepository;
using SIM.Domain;
using SIM.MongoDB;

namespace SIM.Application
{
    public class UserApp
    {
        private IUserRepository service = new UserRepository();

        public List<User> GetUsers()
        {
            return service.FindList(d => true);
        }

        public Task<User> GetUserById(Guid id)
        {
            return service.GetByIdAsync(id);
        }
        public void Add(User item)
        {
            service.Add(item);
        }

        public bool updateone(User item)
        {
            return service.Updat(item);
        }

        public User UpdateByName(string name, User item)
        {
            return service.SaveAsync(d => d.LoginName.Contains(name), item);
        }
    }
}
