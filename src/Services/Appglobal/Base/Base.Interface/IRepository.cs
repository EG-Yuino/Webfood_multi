using Microsoft.EntityFrameworkCore;
using System;

namespace APIglobal.Base.BaseInterface
{
    public interface IRepository<T> where T : class
    {
        //Set Typte Class entity
        DbSet<T> Entities { get; }
        DbContext DbContext { get; }

        /// <summary>
        /// Gets all item of an entity ASYNCHRONOUS 
        /// </summary>
        /// <returns></returns>
        Task<IList<T>> GetAllAsync();

        /// <summary>
        /// Find all item of an entity
        /// </summary>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        T? Find(params object[] keyValues);

        /// <summary>
        /// Find all item of an entity by ASYNCHRONOUS 
        /// </summary>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        Task<T?> FindAsync(params object[] keyValues);

        /// <summary>
        /// Insert item into an entity by ASYNCHRONOUS
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task AddAsync(T entity);

        /// <summary>
        ///  Insert multiple items into an entity by ASYNCHRONOUS
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task AddRangeAsync(IEnumerable<T> entities);

        /// <summary>
        /// Remove one item from an entity by ASYNCHRONOUS
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void RemoveAsync(T entity);

        /// <summary>
        /// Remove multiple items from an entity by ASYNCHRONOUS
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        void RemoveRangeAsync(IEnumerable<T> entities);
    }
}