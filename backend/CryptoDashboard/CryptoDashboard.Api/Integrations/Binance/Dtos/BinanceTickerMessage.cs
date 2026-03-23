using System.Text.Json.Serialization;

namespace CryptoDashboard.Api.Integrations.Binance.Dtos;

internal sealed record BinanceTickerMessage
{
    /// <summary>
    /// Type of event emitted by the stream.
    /// </summary>
    [JsonPropertyName("e")]
    public string EventType { get; init; } = "";

    /// <summary>
    /// Event time as a Unix timestamp in milliseconds.
    /// </summary>
    [JsonPropertyName("E")]
    public long EventTime { get; init; }

    /// <summary>
    /// Trading pair symbol, for example BTCEUR.
    /// </summary>
    [JsonPropertyName("s")]
    public string Symbol { get; init; } = "";

    /// <summary>
    /// Absolute price change over the rolling window.
    /// </summary>
    [JsonPropertyName("p")]
    public decimal PriceChange { get; init; }

    /// <summary>
    /// Percentage price change over the rolling window.
    /// </summary>
    [JsonPropertyName("P")]
    public decimal PriceChangePercent { get; init; }

    /// <summary>
    /// Weighted average price over the rolling window.
    /// </summary>
    [JsonPropertyName("w")]
    public decimal WeightedAveragePrice { get; init; }

    /// <summary>
    /// First trade price before the rolling window.
    /// </summary>
    [JsonPropertyName("x")]
    public decimal FirstTradeBeforeWindowPrice { get; init; }

    /// <summary>
    /// Last traded price.
    /// </summary>
    [JsonPropertyName("c")]
    public decimal LastPrice { get; init; }

    /// <summary>
    /// Quantity of the last trade.
    /// </summary>
    [JsonPropertyName("Q")]
    public decimal LastQuantity { get; init; }

    /// <summary>
    /// Current best bid price.
    /// </summary>
    [JsonPropertyName("b")]
    public decimal BestBidPrice { get; init; }

    /// <summary>
    /// Quantity available at the best bid price.
    /// </summary>
    [JsonPropertyName("B")]
    public decimal BestBidQuantity { get; init; }

    /// <summary>
    /// Current best ask price.
    /// </summary>
    [JsonPropertyName("a")]
    public decimal BestAskPrice { get; init; }

    /// <summary>
    /// Quantity available at the best ask price.
    /// </summary>
    [JsonPropertyName("A")]
    public decimal BestAskQuantity { get; init; }

    /// <summary>
    /// Opening price for the rolling window.
    /// </summary>
    [JsonPropertyName("o")]
    public decimal OpenPrice { get; init; }

    /// <summary>
    /// Highest price in the rolling window.
    /// </summary>
    [JsonPropertyName("h")]
    public decimal HighPrice { get; init; }

    /// <summary>
    /// Lowest price in the rolling window.
    /// </summary>
    [JsonPropertyName("l")]
    public decimal LowPrice { get; init; }

    /// <summary>
    /// Total traded base asset volume.
    /// </summary>
    [JsonPropertyName("v")]
    public decimal TotalTradedBaseAssetVolume { get; init; }

    /// <summary>
    /// Total traded quote asset volume.
    /// </summary>
    [JsonPropertyName("q")]
    public decimal TotalTradedQuoteAssetVolume { get; init; }

    /// <summary>
    /// Statistics window open time as a Unix timestamp in milliseconds.
    /// </summary>
    [JsonPropertyName("O")]
    public long StatisticsOpenTime { get; init; }

    /// <summary>
    /// Statistics window close time as a Unix timestamp in milliseconds.
    /// </summary>
    [JsonPropertyName("C")]
    public long StatisticsCloseTime { get; init; }

    /// <summary>
    /// Identifier of the first trade in the window.
    /// </summary>
    [JsonPropertyName("F")]
    public long FirstTradeId { get; init; }

    /// <summary>
    /// Identifier of the last trade in the window.
    /// </summary>
    [JsonPropertyName("L")]
    public long LastTradeId { get; init; }

    /// <summary>
    /// Total number of trades in the window.
    /// </summary>
    [JsonPropertyName("n")]
    public long TotalNumberOfTrades { get; init; }
}