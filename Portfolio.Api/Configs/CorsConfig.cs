namespace Portfolio.Api.Configs;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using Portfolio.Api.Settings;
using System.Diagnostics.CodeAnalysis;

/// <summary>
/// API CORS configuration.
/// </summary>
[ExcludeFromCodeCoverage]
public static class CorsConfig
{
    /// <summary>
    /// API CORS configuration.
    /// </summary>
    /// <param name="builder">The <see cref="WebApplicationBuilder" /> to configure.</param>
    /// <returns>
    /// The <see cref="WebApplicationBuilder" />.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if AllowedOriginsSettings have not been configured.</exception>
    public static WebApplicationBuilder ConfigureCors(this WebApplicationBuilder builder)
    {
        var apiSettings = builder.Configuration.GetRequiredSection(nameof(ApiSettings)).Get<ApiSettings>();
        var allowedOrigins = apiSettings?.AllowedOrigins.Split(';');

        builder.Services.AddCors(options =>
        {
            options.AddPolicy(
                name: "AllowWebAppOrigin",
                policy =>
                {
                    policy
                        .WithOrigins(allowedOrigins ?? Array.Empty<string>())
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .AllowAnyHeader();
                });
        });

        return builder;
    }
}