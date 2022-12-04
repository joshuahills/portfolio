namespace Portfolio.Api.Settings;

/// <summary>
/// Azure Active Directory settings.
/// </summary>
public class AzureActiveDirectorySettings
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AzureActiveDirectorySettings"/> class.
    /// </summary>
    public AzureActiveDirectorySettings()
    {
        Instance = string.Empty;
        Domain = string.Empty;
        ClientId = string.Empty;
        TenantId = string.Empty;
    }

    /// <summary>
    /// Gets or sets the instance.
    /// </summary>
    /// <value>
    /// The instance.
    /// </value>
    public string Instance { get; set; }

    /// <summary>
    /// Gets or sets the domain.
    /// </summary>
    /// <value>
    /// The domain.
    /// </value>
    public string Domain { get; set; }

    /// <summary>
    /// Gets or sets the client identifier.
    /// </summary>
    /// <value>
    /// The client identifier.
    /// </value>
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or sets the tenant identifier.
    /// </summary>
    /// <value>
    /// The tenant identifier.
    /// </value>
    public string TenantId { get; set; }
}
