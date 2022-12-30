namespace Portfolio.Api.Settings;

/// <summary>
/// The allowed origins settings.
/// </summary>
public class ApiSettings
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Settings.ApiSettings"/> class.
    /// </summary>
    public ApiSettings()
    {
        AllowedOrigins = string.Empty;
    }

    /// <summary>
    /// Gets or sets the allowed origins.
    /// </summary>
    /// <value>
    /// The allowed origins.
    /// </value>
    public string AllowedOrigins { get; set; }
}
