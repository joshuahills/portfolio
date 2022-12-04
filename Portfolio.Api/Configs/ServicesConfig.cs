namespace Portfolio.Api.Configs;

using System.Diagnostics.CodeAnalysis;

/// <summary>
/// IoC configuration for services.
/// </summary>
[ExcludeFromCodeCoverage]
public static class ServicesConfig
{
    /// <summary>
    /// IoC configuration for services.
    /// </summary>
    /// <param name="builder">The <see cref="WebApplicationBuilder" /> to configure.</param>
    /// <returns>
    /// The <see cref="WebApplicationBuilder" />.
    /// </returns>
    public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen();

        return builder;
    }
}