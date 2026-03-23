using System.Text.Json.Serialization;

namespace CryptoDashboard.Api.Integrations.CoinGecko.Dtos;

public sealed record SparklineDto
{
    [JsonPropertyName("price")]
    public List<decimal> Price { get; init; } = [];
}