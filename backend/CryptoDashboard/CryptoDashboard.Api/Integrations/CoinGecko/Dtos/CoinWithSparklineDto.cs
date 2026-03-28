using System.Text.Json.Serialization;

namespace CryptoDashboard.Api.Integrations.CoinGecko.Dtos;

public class CoinWithSparklineDto
{
    [JsonPropertyName("id")]
    public string Id { get; init; } = "";
    
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = "";
    
    [JsonPropertyName("name")]
    public string Name { get; init; } = "";
    
    [JsonPropertyName("image")]
    public string Image { get; init; } = "";
    
    [JsonPropertyName("current_price")]
    public decimal CurrentPrice { get; init; }
    
    [JsonPropertyName("market_cap")]
    public decimal MarketCap { get; init; }
    
    [JsonPropertyName("market_cap_rank")]
    public int MarketCapRank { get; init; }
    
    [JsonPropertyName("fully_diluted_valuation")]
    public decimal FullyDilutedValuation { get; init; }
    
    [JsonPropertyName("total_volume")]
    public long TotalVolume { get; init; }
    
    [JsonPropertyName("high_24h")]
    public decimal High24H { get; init; }

    [JsonPropertyName("low_24h")]
    public decimal Low24H { get; init; }

    [JsonPropertyName("price_change_24h")]
    public decimal PriceChange24H { get; init; }

    [JsonPropertyName("price_change_percentage_24h")]
    public decimal PriceChangePercentage24H { get; init; }

    [JsonPropertyName("market_cap_change_24h")]
    public decimal MarketCapChange24H { get; init; }

    [JsonPropertyName("market_cap_change_percentage_24h")]
    public decimal MarketCapChangePercentage24H { get; init; }

    [JsonPropertyName("circulating_supply")]
    public decimal CirculatingSupply { get; init; }

    [JsonPropertyName("total_supply")]
    public decimal TotalSupply { get; init; }

    [JsonPropertyName("max_supply")]
    public decimal? MaxSupply { get; init; }

    [JsonPropertyName("ath")]
    public decimal Ath { get; init; }

    [JsonPropertyName("ath_change_percentage")]
    public decimal AthChangePercentage { get; init; }

    [JsonPropertyName("ath_date")]
    public DateTimeOffset AthDate { get; init; }

    [JsonPropertyName("atl")]
    public decimal Atl { get; init; }

    [JsonPropertyName("atl_change_percentage")]
    public decimal AtlChangePercentage { get; init; }

    [JsonPropertyName("atl_date")]
    public DateTimeOffset AtlDate { get; init; }

    [JsonPropertyName("roi")]
    public object? Roi { get; init; }

    [JsonPropertyName("last_updated")]
    public DateTimeOffset LastUpdated { get; init; }

    [JsonPropertyName("sparkline_in_7d")]
    public SparklineDto SparklineIn7D { get; init; } = new();

    [JsonPropertyName("price_change_percentage_7d_in_currency")]
    public decimal PriceChangePercentage7DInCurrency { get; init; }
}

