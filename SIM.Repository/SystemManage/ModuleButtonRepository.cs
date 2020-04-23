
using SIM.Data;
using SIM.Domain.Entity.SystemManage;
using SIM.Domain.IRepository.SystemManage;
using SIM.Repository.SystemManage;
using System.Collections.Generic;

namespace SIM.Repository.SystemManage
{
    public class ModuleButtonRepository : RepositoryBase<ModuleButtonEntity>, IModuleButtonRepository
    {
        public void SubmitCloneButton(List<ModuleButtonEntity> entitys)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                foreach (var item in entitys)
                {
                    db.Insert(item);
                }
                db.Commit();
            }
        }
    }
}
