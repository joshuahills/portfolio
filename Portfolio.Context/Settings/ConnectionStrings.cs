namespace Portfolio.Context.Settings;

public class ConnectionStrings
{
	public ConnectionStrings()
	{
		PortfolioDatabase = string.Empty;
	}
	public string PortfolioDatabase { get; set; }
}
