namespace Portfolio.Api.Repositories;

using Microsoft.EntityFrameworkCore;
using Portfolio.Context;
using Portfolio.Context.Models;

/// <summary>
/// The posts repository.
/// </summary>
/// <seealso cref="Portfolio.Api.Repositories.BaseRepository&lt;Portfolio.Context.Models.Post&gt;" />
/// <seealso cref="Portfolio.Api.Repositories.IPostsRepository" />
public class PostsRepository : BaseRepository<Post>, IPostsRepository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PostsRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The database context.</param>
    public PostsRepository(PortfolioContext dbContext)
        : base(dbContext)
    {
    }

    /// <summary>
    /// Gets the posts.
    /// </summary>
    /// <returns>The posts.</returns>
    public IQueryable<Post> GetPosts()
    {
        return GetAll().AsNoTracking();
    }
}
