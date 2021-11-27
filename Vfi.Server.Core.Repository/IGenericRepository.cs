using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.Repository
{
    public interface IGenericRepository<T> : IRepositoryBase where T : class
    {

        /// <summary>
        /// Returns all entities for a given type
        /// </summary>
        /// <returns>All entities</returns>
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllAsNoTracking();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        IEnumerable<T> Find(Func<T, bool> where);
        IEnumerable<T> FindAsNoTracking(Func<T, bool> where);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        T Single(Func<T, bool> where);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        T First(Func<T, bool> where);

        // DbDataRecord -> using System.Data.Common;
        // ObjectQuery -> using System.Data.Objects;
        //ObjectQuery<DbDataRecord> CreateObjectQuery(string sqlQueryString, List<ObjectParameter> objectParameters);
        //ObjectQuery<DbDataRecord> CreateObjectQuery(string sqlQueryString);

        /// <summary>
        /// Add entity to the repository
        /// </summary>
        /// <param name="entity">the entity to add</param>
        /// <returns>The added entity</returns>
        void Add(T entity);

        /// <summary>
        /// Mark entity to be deleted within the repository
        /// </summary>
        /// <param name="entity">The entity to delete</param>
        void Delete(T entity);

        /// <summary>
        /// Mark entity to be deleted within the repository in the query
        /// </summary>
        /// <param name="predicate">bool</param>
        void Delete(Func<T, Boolean> predicate);

        /// <summary>
        /// GetAllAndChildren
        /// </summary>
        /// <param name="children"></param>
        /// <returns>IEnumerable T</returns>
        /// 
        IEnumerable<T> GetAllAndChildren(string children);

        IEnumerable<T> GetAllAndChildren(string[] children);
    }
}
