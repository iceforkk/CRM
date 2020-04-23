
using SIM.Data;
using SIM.Domain.Entity.SystemManage;
using System.Collections.Generic;

namespace SIM.Domain.IRepository.SystemManage
{
    public interface IItemsDetailRepository : IRepositoryBase<ItemsDetailEntity>
    {
        List<ItemsDetailEntity> GetItemList(string enCode);
    }
}
