namespace Portfolio.Api.Configs;

using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Configuration for the API.
/// </summary>
[ExcludeFromCodeCoverage]
public static class ApiConfig
{
    /// <summary>
    /// Configures the API.
    /// </summary>
    /// <param name="app">The <see cref="WebApplication" /> to configure.</param>
    /// <returns>
    /// The <see cref="WebApplication" />.
    /// </returns>
    public static WebApplication ConfigureApi(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger()
               .UseSwaggerUI();
        }

        app.UseHttpsRedirection()
            .UseAuthentication()
            .UseRouting()
            .UseCors("AllowWebAppOrigin")
            .UseAuthorization()
            .UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        return app;
    }
}