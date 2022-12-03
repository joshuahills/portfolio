namespace Portfolio.Api.Controllers;

using Microsoft.AspNetCore.Mvc;

/// <summary>
/// The posts controller.
/// </summary>
[ApiController]
[Route("[controller]")]
public class PostsController : ControllerBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PostsController"/> class.
    /// </summary>
    public PostsController()
    {
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