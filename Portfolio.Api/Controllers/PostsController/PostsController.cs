namespace Portfolio.Api.Controllers;

using Microsoft.AspNetCore.Mvc;

/// <summary>
/// The posts controller.
/// </summary>
[ApiController]
[Route("[controller]")]
public class PostsController : ControllerBase
{
    /// <summary>The logger.</summary>
    private readonly ILogger<PostsController> logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="PostsController"/> class.
    /// </summary>
    /// <param name="logger">The logger.</param>
    public PostsController(ILogger<PostsController> logger)
    {
        this.logger = logger;
    }

    /// <summary>
    /// Gets the post.
    /// </summary>
    /// <returns>The post as a <see cref="PostDto"/>.</returns>
    [HttpGet]
    public PostDto GetPost()
    {
        return new PostDto();
    }
}