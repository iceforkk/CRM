using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM.MongoDB
{
    /// <summary>
    /// 表示聚合根
    /// </summary>
    public interface IAggregateRoot : IEntity
    {

    }
    /// <summary>
    /// 表示聚合根
    /// </summary>
    public interface IAggregateRoot<TKey> : IEntity where TKey : IComparable
    {
        /// <summary>
        /// 获取标识
        /// </summary> 
        TKey Id { get; set; }
    }
}
