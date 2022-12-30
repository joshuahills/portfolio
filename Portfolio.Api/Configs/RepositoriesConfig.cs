namespace Portfolio.Api.Configs;

using Portfolio.Api.Repositories;
using Portfolio.Api.Services;
using System.Diagnostics.CodeAnalysis;

/// <summary>
/// IoC configuration for repositories.
/// </summary>
[ExcludeFromCodeCoverage]
public static class RepositoriesConfig
{
    /// <summary>
    /// IoC configuration for repositories.
    /// </summary>
    /// <param name="builder">The <see cref="WebApplicationBuilder" /> to configure.</param>
    /// <returns>
    /// The <see cref="WebApplicationBuilder" />.
    /// </returns>
    public static WebApplicationBuilder ConfigureRepositories(this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IPostsRepository, PostsRepository>();

        return builder;
    }
}