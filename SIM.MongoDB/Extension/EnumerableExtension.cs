using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM.MongoDB
{
    public static class EnumerableExtension
    {
        /// <summary>
        /// mongodb数组原子添加
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static List<T> Push<T>(this IEnumerable<T> list, T t)
        {
            return null;
        }

        /// <summary>
        /// mongodb数组原子删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static List<T> Pull<T>(this IEnumerable<T> list, T t)
        {
            return null;
        }

        /// <summary>
        /// mongodb数组原子添加
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static List<T> AddToSet<T>(this IEnumerable<T> list, T t)
        {
            return null;
        }
    }
}
