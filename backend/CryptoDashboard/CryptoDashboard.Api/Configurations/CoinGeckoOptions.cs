namespace CryptoDashboard.Api.Configurations;

public class CoinGeckoOptions
{
    public const string ConfigKey = "CoinGecko";

    public string ApiUrl { get; init; } = "";

    public string ApiKey { get; init; } = "";

    public string HeaderApiKey { get; init; } = ""; 
}