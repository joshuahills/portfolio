namespace Portfolio.Context.Models;

public class Post
{
    public int Id { get; set; }
    
    public string Title { get; set; } = string.Empty;

    public string Content {  get; set; } = string.Empty;

    public DateTimeOffset CreatedTimestamp { get; set; }

    public DateTimeOffset? UpdatedTimestamp { get; set; }
}
