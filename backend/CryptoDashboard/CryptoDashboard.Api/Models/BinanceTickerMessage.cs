using System.Text.Json.Serialization;

namespace CryptoDashboard.Api.Models;

public sealed record BinanceTickerMessage
{
    [JsonPropertyName("e")]
    public string EventType { get; init; } = "";

    [JsonPropertyName("E")]
    public long EventTime { get; init; }

    [JsonPropertyName("s")]
    public string Symbol { get; init; } = "";

    [JsonPropertyName("p")]
    public string PriceChange { get; init; } = "";

    [JsonPropertyName("P")]
    public string PriceChangePercent { get; init; } = "";

    [JsonPropertyName("w")]
    public string WeightedAveragePrice { get; init; } = "";

    [JsonPropertyName("x")]
    public string FirstTradeBeforeWindowPrice { get; init; } = "";

    [JsonPropertyName("c")]
    public string LastPrice { get; init; } = "";

    [JsonPropertyName("Q")]
    public string LastQuantity { get; init; } = "";

    [JsonPropertyName("b")]
    public string BestBidPrice { get; init; } = "";

    [JsonPropertyName("B")]
    public string BestBidQuantity { get; init; } = "";

    [JsonPropertyName("a")]
    public string BestAskPrice { get; init; } = "";

    [JsonPropertyName("A")]
    public string BestAskQuantity { get; init; } = "";

    [JsonPropertyName("o")]
    public string OpenPrice { get; init; } = "";

    [JsonPropertyName("h")]
    public string HighPrice { get; init; } = "";

    [JsonPropertyName("l")]
    public string LowPrice { get; init; } = "";

    [JsonPropertyName("v")]
    public string TotalTradedBaseAssetVolume { get; init; } = "";

    [JsonPropertyName("q")]
    public string TotalTradedQuoteAssetVolume { get; init; } = "";

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