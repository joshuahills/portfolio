namespace Portfolio.Api;

using System.Diagnostics.CodeAnalysis;
using Portfolio.Api.Configs;

/// <summary>
/// The program.
/// </summary>
[ExcludeFromCodeCoverage]
public static class Program
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    public static void Main()
    {
        var builder = WebApplication
                .CreateBuilder()
                .ConfigureControllers()
                .ConfigureSettings()
                .ConfigureServices();

        var app = builder
            .Build()
            .ConfigureApi();

        app.Run();
    }
}
