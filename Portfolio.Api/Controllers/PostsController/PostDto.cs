namespace Portfolio.Api.Controllers;

using Portfolio.Context.Models;

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
    /// Initializes a new instance of the <see cref="PostDto"/> class.
    /// </summary>
    /// <param name="post">The post.</param>
    public PostDto(Post post)
    {
        this.Id = post.Id;
        this.Title = post.Title;
        this.Content = post.Content;
        this.CreatedTime = post.CreatedTimestamp;
        this.UpdatedTime = post.UpdatedTimestamp;
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
    /// Gets or sets the created time.
    /// </summary>
    /// <value>
    /// The created time.
    /// </value>
    public DateTimeOffset CreatedTime { get; set; }

    /// <summary>
    /// Gets or sets the updated time.
    /// </summary>
    /// <value>
    /// The updated time.
    /// </value>
    public DateTimeOffset? UpdatedTime { get; set; }
}
