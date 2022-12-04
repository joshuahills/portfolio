namespace Portfolio.Api.Configs;

using Portfolio.Api.Settings;
using System.Diagnostics.CodeAnalysis;

/// <summary>
/// IoC configuration for settings.
/// </summary>
[ExcludeFromCodeCoverage]
public static class SettingsConfig
{
    /// <summary>
    /// IoC configuration for settings.
    /// </summary>
    /// <param name="builder">The <see cref="WebApplicationBuilder" /> to configure.</param>
    /// <returns>
    /// The <see cref="WebApplicationBuilder" />.
    /// </returns>
    public static WebApplicationBuilder ConfigureSettings(this WebApplicationBuilder builder)
    {
        var azureActiveDirectorySettingsSection = builder.Configuration.GetSection(nameof(AzureActiveDirectorySettings));

        builder.Services.Configure<AzureActiveDirectorySettings>(azureActiveDirectorySettingsSection);

        return builder;
    }
}