using System.Text.Json;
using CryptoDashboard.Api.Integrations.CoinGecko;
using CryptoDashboard.Api.Integrations.CoinGecko.Dtos;
using MediatR;

namespace CryptoDashboard.Api.Features.CoinList;

public class CoinListQueryHandler(CoinGeckoClient coinGeckoClient) : IRequestHandler<CoinListQuery, CoinListResponse[]>
{
    public async Task<CoinListResponse[]> Handle(CoinListQuery request, CancellationToken cancellationToken)
    {
        var result = await coinGeckoClient.GetCoinsAsync(cancellationToken);
        var coinsByMarketCap = JsonSerializer.Deserialize<CoinWithSparklineDto[]>(result);

        if (coinsByMarketCap is null) return [];
        
        var coinListResponse = coinsByMarketCap.Select(c =>
            new CoinListResponse(
                c.Id,
                c.Symbol,
                c.Name,
                c.Image,
                c.CurrentPrice,
                c.PriceChangePercentage24H,
                c.PriceChangePercentage7DInCurrency,
                c.SparklineIn7D)
        ).ToArray();
        
        return coinListResponse;
    }
}