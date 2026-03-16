using System.Text.Json.Serialization;

namespace CryptoDashboard.Api.Models;

internal sealed record BinanceTickerMessage
{
    [JsonPropertyName("e")]
    public string EventType { get; init; } = "";

    [JsonPropertyName("E")]
    public long EventTime { get; init; }

    [JsonPropertyName("s")]
    public string Symbol { get; init; } = "";

    [JsonPropertyName("p")]
    public decimal PriceChange { get; init; }

    [JsonPropertyName("P")]
    public decimal PriceChangePercent { get; init; }

    [JsonPropertyName("w")]
    public decimal WeightedAveragePrice { get; init; }

    [JsonPropertyName("x")]
    public decimal FirstTradeBeforeWindowPrice { get; init; }

    [JsonPropertyName("c")]
    public decimal LastPrice { get; init; }

    [JsonPropertyName("Q")]
    public decimal LastQuantity { get; init; }

    [JsonPropertyName("b")]
    public decimal BestBidPrice { get; init; }

    [JsonPropertyName("B")]
    public decimal BestBidQuantity { get; init; }

    [JsonPropertyName("a")]
    public decimal BestAskPrice { get; init; }

    [JsonPropertyName("A")]
    public decimal BestAskQuantity { get; init; }

    [JsonPropertyName("o")]
    public decimal OpenPrice { get; init; }

    [JsonPropertyName("h")]
    public decimal HighPrice { get; init; }

    [JsonPropertyName("l")]
    public decimal LowPrice { get; init; }

    [JsonPropertyName("v")]
    public decimal TotalTradedBaseAssetVolume { get; init; }

    [JsonPropertyName("q")]
    public decimal TotalTradedQuoteAssetVolume { get; init; }

    [JsonPropertyName("O")]
    public long StatisticsOpenTime { get; init; }

    [JsonPropertyName("C")]
    public long StatisticsCloseTime { get; init; }

    [JsonPropertyName("F")]
    public long FirstTradeId { get; init; }

    [JsonPropertyName("L")]
    public long LastTradeId { get; init; }

    [JsonPropertyName("n")]
    public long TotalNumberOfTrades { get; init; }
}