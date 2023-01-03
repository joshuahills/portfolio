namespace Portfolio.Api.Services;

using Portfolio.Api.Controllers;

/// <summary>
/// The posts service.
/// </summary>
public interface IPostsService
{
    /// <summary>
    /// Gets all posts.
    /// </summary>
    /// <returns>All posts.</returns>
    IEnumerable<PostDto> GetAllPosts();

    /// <summary>
    /// Gets a single post.
    /// </summary>
    /// <param name="id">The post identifier.</param>
    /// <returns>The post with the corresponding identifier if found; otherwise <c>null</c>.</returns>
    PostDto? GetPost(int id);

    /// <summary>
    /// Creates a post.
    /// </summary>
    /// <param name="post">The post to create.</param>
    /// <returns>The created post.</returns>
    PostDto CreatePost(PostDto post);

    /// <summary>
    /// Updates a post.
    /// </summary>
    /// <param name="post">The post to update.</param>
    /// <returns>The updated post.</returns>
    PostDto UpdatePost(PostDto post);

    /// <summary>
    /// Deletes the post.
    /// </summary>
    /// <param name="id">The post identifier to delete.</param>
    void DeletePost(int id);
}
