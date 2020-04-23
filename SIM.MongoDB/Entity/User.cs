using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM.MongoDB
{
    public partial class User : EntityBase<Guid>
    {
        public string LoginName { get; set; }
        public string LoginPwd { get; set; } 
        public Gender Gender { get; set; } 
        public List<UserType> userTypes {get;set;}
    }

    public enum Gender
    {
        Male, Female
    }

    public class UserType
    {
        public string TypeName{get;set;} 
        public string TypeCont{get;set; }
    }
}
