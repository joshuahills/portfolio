namespace Portfolio.Api.Configs;

using Microsoft.EntityFrameworkCore;
using Portfolio.Api.Repositories;
using Portfolio.Api.Services;
using Portfolio.Context;
using Portfolio.Context.Settings;
using System.Diagnostics.CodeAnalysis;

/// <summary>
/// IoC config for database functionality.
/// </summary>
[ExcludeFromCodeCoverage]
public static class DatabaseConfig
{
    /// <summary>
    /// Database configuration.
    /// </summary>
    /// <param name="builder">The <see cref="WebApplicationBuilder" /> to configure.</param>
    /// <returns>
    /// The <see cref="WebApplicationBuilder" />.
    /// </returns>
    public static WebApplicationBuilder ConfigureDatabase(this WebApplicationBuilder builder)
    {
        var connectionStrings = builder.Configuration
            .GetSection(nameof(ConnectionStrings))
            .Get<ConnectionStrings>();

        builder.Services.AddDbContext<PortfolioContext>(
            options => options.UseSqlServer(connectionStrings?.PortfolioDatabase));

        return builder;
    }
}