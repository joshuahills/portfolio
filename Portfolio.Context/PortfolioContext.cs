namespace Portfolio.Context;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Portfolio.Context.Models;
using Portfolio.Context.Settings;

public class PortfolioContext : DbContext
{
	public DbSet<Post> Post => Set<Post>();

	public PortfolioContext() : base()
	{
	}

	public PortfolioContext(DbContextOptions<PortfolioContext> options)
		: base(options)
	{
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		if (!optionsBuilder.IsConfigured)
		{
			SetupConnectionString(optionsBuilder);
		}

		base.OnConfiguring(optionsBuilder);
	}

	private static void SetupConnectionString(DbContextOptionsBuilder optionsBuilder)
	{
		var builder = new ConfigurationBuilder()
			.SetBasePath(AppContext.BaseDirectory)
			.AddJsonFile("appsettings.ef.json");

		var config = builder.Build();

		var connectionString = config?
			.GetRequiredSection(nameof(ConnectionStrings))?
			.Get<ConnectionStrings>()?
			.PortfolioDatabase;

		optionsBuilder.UseSqlServer(connectionString);
	}
}
