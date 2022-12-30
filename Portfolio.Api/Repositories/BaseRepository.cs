namespace Portfolio.Api.Repositories;

using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

/// <summary>
/// The base repository.
/// </summary>
/// <typeparam name="TEntity">The type of the entity.</typeparam>
/// <seealso cref="Portfolio.Api.Repositories.IBaseRepository&lt;TEntity&gt;" />
public class BaseRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : class
{
    /// <summary>
    /// The database context.
    /// </summary>
    private readonly DbContext dbContext;

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseRepository{TEntity}"/> class.
    /// </summary>
    /// <param name="dbContext">The database context.</param>
    public BaseRepository(DbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    /// <summary>
    /// Inserts the specified entity.
    /// </summary>
    /// <param name="entity">The entity.</param>
    public void Insert(TEntity entity)
    {
        dbContext.Set<TEntity>().Add(entity);
        dbContext.SaveChanges();
    }

    /// <summary>
    /// Deletes the specified entity.
    /// </summary>
    /// <param name="entity">The entity.</param>
    public void Delete(TEntity entity)
    {
        dbContext.Set<TEntity>().Remove(entity);
        dbContext.SaveChanges();
    }

    /// <summary>
    /// Searches for data matching the specified search query.
    /// </summary>
    /// <param name="predicate">The predicate.</param>
    /// <returns>
    /// The results matching the query.
    /// </returns>
    public IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
    {
        return dbContext.Set<TEntity>().Where(predicate);
    }

    /// <summary>
    /// Searches for single or default.
    /// </summary>
    /// <param name="predicate">The predicate.</param>
    /// <returns>The result matching the query; otherwise <c>null</c>.</returns>
    public TEntity? SearchForSingleOrDefault(Expression<Func<TEntity, bool>> predicate)
    {
        return dbContext.Set<TEntity>().SingleOrDefault(predicate);
    }

    /// <summary>
    /// Gets all.
    /// </summary>
    /// <returns>
    /// All entities.
    /// </returns>
    public IQueryable<TEntity> GetAll()
    {
        return dbContext.Set<TEntity>();
    }

    /// <summary>
    /// Gets by the primary key.
    /// </summary>
    /// <param name="primaryKey">The primary key.</param>
    /// <returns>
    /// The entity with the corresponding primary key; otherwise <c>null</c>.
    /// </returns>
    public TEntity? GetByPrimaryKey(params object[] primaryKey)
    {
        return dbContext.Set<TEntity>().Find(primaryKey);
    }

    /// <summary>
    /// Updates the entity.
    /// </summary>
    /// <param name="entityToUpdate">The entity to update.</param>
    /// <returns>
    /// The updated entity.
    /// </returns>
    /// <exception cref="System.ArgumentNullException">Thrown if entityToUpdate is null.</exception>
    public TEntity UpdateEntity(TEntity entityToUpdate)
    {
        if (entityToUpdate == null)
        {
            throw new ArgumentNullException($"{nameof(entityToUpdate)}");
        }

        if (dbContext.Entry(entityToUpdate).State != EntityState.Added)
        {
            dbContext.Entry(entityToUpdate).State = EntityState.Modified;
        }

        dbContext.SaveChanges();
        return entityToUpdate;
    }
}
