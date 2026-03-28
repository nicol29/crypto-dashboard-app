using CryptoDashboard.Api.Interfaces;
using MediatR;

namespace CryptoDashboard.Api.Features.CoinList;

public class CoinListEndpoints : IEndpointDefinition
{
    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet("api/coins", async (IMediator mediator) => await mediator.Send(new CoinListQuery()))
            .WithName("GetCoins");
    }
}