using System.Linq.Expressions;

namespace ECommerce.Application.Interfaces
{
    /// <summary>
    /// IRepository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// GetAll
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Where
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// GetByIdAsync
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ValueTask<T?> GetByIdAsync(int id);

        /// <summary>
        /// AddAsync
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task AddAsync(T entity);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// SaveChangesAsync
        /// </summary>
        /// <returns></returns>
        Task<int> SaveChangesAsync();
    }
}
