
using SIM.Data;
using SIM.Domain.Entity.SystemManage;
using System.Collections.Generic;

namespace SIM.Domain.IRepository.SystemManage
{
    public interface IModuleButtonRepository : IRepositoryBase<ModuleButtonEntity>
    {
        void SubmitCloneButton(List<ModuleButtonEntity> entitys);
    }
}
