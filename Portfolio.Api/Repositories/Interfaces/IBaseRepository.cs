namespace Portfolio.Api.Repositories;

using System.Linq.Expressions;

/// <summary>
/// The base repository.
/// </summary>
/// <typeparam name="T">The entity.</typeparam>
public interface IBaseRepository<T>
{
    /// <summary>
    /// Inserts the specified entity.
    /// </summary>
    /// <param name="entity">The entity.</param>
    void Insert(T entity);

    /// <summary>
    /// Deletes the specified entity.
    /// </summary>
    /// <param name="entity">The entity.</param>
    void Delete(T entity);

    /// <summary>
    /// Searches for data matching the specified search query.
    /// </summary>
    /// <param name="predicate">The predicate.</param>
    /// <returns>The results matching the query.</returns>
    IQueryable<T>? SearchFor(Expression<Func<T, bool>> predicate);

    /// <summary>
    /// Gets all.
    /// </summary>
    /// <returns>All entities.</returns>
    IQueryable<T> GetAll();

    /// <summary>
    /// Gets the by primary key.
    /// </summary>
    /// <param name="primaryKey">The primary key.</param>
    /// <returns>The entity with the corresponding primary key.</returns>
    T? GetByPrimaryKey(params object[] primaryKey);

    /// <summary>
    /// Updates the entity.
    /// </summary>
    /// <param name="entityToUpdate">The entity to update.</param>
    /// <returns>The updated entity.</returns>
    T UpdateEntity(T entityToUpdate);
}
