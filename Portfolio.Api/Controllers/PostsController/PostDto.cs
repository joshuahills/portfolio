namespace Portfolio.Api.Controllers;

/// <summary>
/// The post data transfer object.
/// </summary>
public class PostDto
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PostDto"/> class.
    /// </summary>
    public PostDto()
    {
        Title = string.Empty;
        Content = string.Empty;
    }

    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    /// <value>
    /// The title.
    /// </value>
    public string Title { get; set; }

    /// <summary>
    /// Gets or sets the content.
    /// </summary>
    /// <value>
    /// The content.
    /// </value>
    public string Content { get; set; }

    /// <summary>
    /// Gets or sets the author identifier.
    /// </summary>
    /// <value>
    /// The author identifier.
    /// </value>
    public int AuthorId { get; set; }
}
