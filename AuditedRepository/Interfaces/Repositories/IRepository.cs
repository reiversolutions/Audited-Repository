using AuditedRepository.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AuditedRepository.Interfaces.Repositories
{
    /// <summary>
    /// Generic Repository
    /// </summary>
    /// <typeparam name="T">Entity implementing IEntity</typeparam>
    public interface IRepository<T> where T : IEntity
    {
        /// <summary>
        /// Check if a query returns any entities
        /// </summary>
        /// <param name="query">Filter query</param>
        /// <returns>Any entities returned</returns>
        bool Any(Expression<Func<T, bool>> query = null);

        /// <summary>
        /// Find all relevant entities
        /// </summary>
        /// <param name="filter">Filter query</param>
        /// <param name="orderBy">Order by options</param>
        /// <param name="offset">Pagination offset</param>
        /// <param name="take">Pagination amount</param>
        /// <param name="includeProperties">Included properties</param>
        /// <returns>List of entities</returns>
        IEnumerable<T> Find(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            long offset = 0,
            long take = long.MaxValue,
            string includeProperties = ""
        );

        /// <summary>
        /// Find specific entity
        /// </summary>
        /// <param name="id">Primary key identifier</param>
        /// <param name="bypassArchived">Ignore the archive filter</param>
        /// <returns>Entity</returns>
        T FindById(string id, bool bypassArchived = false);

        /// <summary>
        /// Insert a entity into the database
        /// </summary>
        /// <param name="entity">Entity to be inserted</param>
        /// <returns>Successful</returns>
        bool Insert(T entity);

        /// <summary>
        /// Update a entity
        /// </summary>
        /// <param name="entity">Entity to update</param>
        /// <returns>Successful</returns>
        bool Update(T entity);

        /// <summary>
        /// Update an entity if it exists or insert it
        /// </summary>
        /// <param name="entity">Entity to update or insert</param>
        /// <returns>Successful</returns>
        bool InsertOrUpdate(T entity);

        /// <summary>
        /// Delete an entity
        /// </summary>
        /// <param name="id">Primary key identifier</param>
        /// <param name="archive">Perform a soft delete</param>
        /// <returns>Successful</returns>
        bool Delete(string id, bool archive = true);
        /// <summary>
        /// Delete an entity
        /// </summary>
        /// <param name="entity">Entity to delete</param>
        /// <param name="archive">Perform a soft delete</param>
        /// <returns>Successful</returns>
        bool Delete(T entity, bool archive = true);

        /// <summary>
        /// Save all previous data modifications
        /// </summary>
        /// <returns>Successful</returns>
        bool Save();
    }
}