namespace Portfolio.Api.Configs;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using Portfolio.Api.Settings;
using System.Diagnostics.CodeAnalysis;

/// <summary>
/// IoC configuration for authentication.
/// </summary>
[ExcludeFromCodeCoverage]
public static class AuthConfig
{
    /// <summary>
    /// IoC configuration for authentication.
    /// </summary>
    /// <param name="builder">The <see cref="WebApplicationBuilder" /> to configure.</param>
    /// <returns>
    /// The <see cref="WebApplicationBuilder" />.
    /// </returns>
    public static WebApplicationBuilder ConfigureAuth(this WebApplicationBuilder builder)
    {
        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                        .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection(nameof(AzureActiveDirectorySettings)));

        return builder;
    }
}