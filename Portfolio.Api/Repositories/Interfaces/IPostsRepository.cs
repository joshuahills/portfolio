namespace Portfolio.Api.Repositories;

using Portfolio.Context.Models;

/// <summary>
/// The posts repository.
/// </summary>
/// <seealso cref="Portfolio.Api.Repositories.IBaseRepository&lt;Portfolio.Context.Models.Post&gt;" />
public interface IPostsRepository : IBaseRepository<Post>
{
    /// <summary>
    /// Gets the posts.
    /// </summary>
    /// <returns>The posts.</returns>
    IQueryable<Post> GetPosts();
}
