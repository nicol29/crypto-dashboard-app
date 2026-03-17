namespace CryptoDashboard.Api.Models;

public class BinanceOptions
{
    public const string ConfigKey = "Binance";
    
    public string WebSocketUrl { get; init; } = "";
}