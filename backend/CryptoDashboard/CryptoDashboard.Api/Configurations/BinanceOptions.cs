namespace CryptoDashboard.Api.Configurations;

public class BinanceOptions
{
    public const string ConfigKey = "Binance";
    
    public string WebSocketUrl { get; init; } = "";
    
    public string ApiUrl { get; init; } = "";
}