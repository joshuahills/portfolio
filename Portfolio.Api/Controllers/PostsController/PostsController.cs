namespace Portfolio.Api.Controllers;

using Microsoft.AspNetCore.Mvc;
using Portfolio.Api.Services;

/// <summary>
/// The posts controller.
/// </summary>
[ApiController]
[Route("[controller]")]
public class PostsController : ControllerBase
{
    private readonly IPostsService postsService;

    /// <summary>
    /// Initializes a new instance of the <see cref="PostsController" /> class.
    /// </summary>
    /// <param name="postsService">The posts service.</param>
    public PostsController(IPostsService postsService)
    {
        this.postsService = postsService;
    }

    /// <summary>
    /// Gets the posts.
    /// </summary>
    /// <returns>The posts.</returns>
    [HttpGet]
    public IEnumerable<PostDto> GetPosts()
    {
        return this.postsService.GetAllPosts();
    }

    /// <summary>
    /// Gets a post by its identifir.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>The post with the given identifier if found; otherwise Not Found.</returns>
    [HttpGet("{id:int}")]
    public IActionResult GetPost(int id)
    {
        var post = this.postsService.GetPost(id);

        if (post is null)
        {
            return NotFound();
        }

        return Ok(post);
    }
}