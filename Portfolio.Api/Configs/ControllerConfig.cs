namespace Portfolio.Api.Configs;

using System.Diagnostics.CodeAnalysis;

/// <summary>
/// IoC configuration for API controllers.
/// </summary>
[ExcludeFromCodeCoverage]
public static class ControllerConfig
{
    /// <summary>
    /// IoC configuration for controllers.
    /// </summary>
    /// <param name="builder">The <see cref="WebApplicationBuilder" /> to configure.</param>
    /// <returns>
    /// The <see cref="WebApplicationBuilder" />.
    /// </returns>
    public static WebApplicationBuilder ConfigureControllers(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();

        return builder;
    }
}