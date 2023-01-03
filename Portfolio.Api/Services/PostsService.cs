namespace Portfolio.Api.Services;

using Portfolio.Api.Controllers;
using Portfolio.Api.Repositories;

/// <summary>
/// The posts service.
/// </summary>
/// <seealso cref="Portfolio.Api.Services.IPostsService" />
public class PostsService : IPostsService
{
    /// <summary>
    /// The posts repository.
    /// </summary>
    private readonly IPostsRepository postsRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="PostsService" /> class.
    /// </summary>
    /// <param name="postsRepository">The posts repository.</param>
    public PostsService(IPostsRepository postsRepository)
    {
        this.postsRepository = postsRepository;
    }

    /// <summary>
    /// Gets all posts.
    /// </summary>
    /// <returns>
    /// All posts.
    /// </returns>
    public IEnumerable<PostDto> GetAllPosts()
    {
        return this.postsRepository.GetPosts().Select(p => new PostDto(p));
    }

    /// <summary>
    /// Creates a post.
    /// </summary>
    /// <param name="post">The post to create.</param>
    /// <returns>
    /// The created post.
    /// </returns>
    public PostDto CreatePost(PostDto post)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Deletes the post.
    /// </summary>
    /// <param name="id">The post identifier to delete.</param>
    public void DeletePost(int id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Gets a single post.
    /// </summary>
    /// <param name="id">The post identifier.</param>
    /// <returns>
    /// The post with the corresponding identifier.
    /// </returns>
    public PostDto? GetPost(int id)
    {
        var post = this.postsRepository.GetByPrimaryKey(id);

        if (post is null)
        {
            return null;
        }

        return new PostDto(post);
    }

    /// <summary>
    /// Updates a post.
    /// </summary>
    /// <param name="post">The post to update.</param>
    /// <returns>
    /// The updated post.
    /// </returns>
    public PostDto UpdatePost(PostDto post)
    {
        throw new NotImplementedException();
    }
}
