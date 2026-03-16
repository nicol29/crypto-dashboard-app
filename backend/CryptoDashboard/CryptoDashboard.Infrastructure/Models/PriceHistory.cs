using System.ComponentModel.DataAnnotations;

namespace CryptoDashboard.Infrastructure.Models;

public class PriceHistory
{
    public long Id { get; init; }
    
    [MaxLength(15)]
    public string CoinSymbol { get; init; } = "";
    
    public decimal Price { get; init; }
    
    public decimal PriceChange { get; init; }
    
    public decimal PriceChangePercent { get; init; }
    
    public decimal DailyHigh { get; init; }
    
    public decimal DailyLow { get; init; }
    
    public decimal Volume { get; init; }
    
    public DateTime RecordedAt { get; init; }
}
    