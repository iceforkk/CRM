using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIM.MongoDB;
using SIM.Application;
using System.Collections.Generic; 
using System.Linq;

namespace TestUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GetUser();
        }
        [TestMethod]
        public void AddUser()
        { 
            var p = new User()
            {
                LoginName = "YuchenghaoList12344",
                Gender = Gender.Male,
                LoginPwd = "213",
                 userTypes=new List<UserType>()
            };
            for (int i = 1; i < 3; i++)
            {
                var k =new UserType()
                {
                     TypeCont=i.ToString(),
                      TypeName="工作人员"
                };
                p.userTypes.Add(k);
            }
            UserApp areaApp = new UserApp();
            areaApp.Add(p); 

        }

        public  List<User> GetUser()
         {
            UserApp areaApp = new UserApp();
            var list= areaApp.GetUsers();
            return list;
        }
        [TestMethod]
        public void Update()
       {
            UserApp areaApp = new UserApp();
            var model=areaApp.GetUsers().FirstOrDefault();
            if(model!=null)
             {
                model.LoginName="UpdateByWhereBYName";
                var mm=areaApp.GetUserById(model.Id);
                //areaApp.updateone(model);
               var update=  areaApp.UpdateByName("UpdateByWhere1", model);
            }
            

        }
    }
}
