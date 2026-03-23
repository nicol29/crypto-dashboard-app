using CryptoDashboard.Api.Integrations.CoinGecko.Dtos;

namespace CryptoDashboard.Api.Features.CoinList;

public record CoinListResponse(
    string CoinId,
    string Symbol,
    string Name,
    string Image,
    decimal CurrentPrice,
    decimal PriceChangePercentage24Hr,
    decimal PriceChangePercentage7DCurrency,
    SparklineDto Sparkline7D);