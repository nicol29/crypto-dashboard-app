using CryptoDashboard.Api.Integrations.CoinGecko.Dtos;
using MediatR;

namespace CryptoDashboard.Api.Features.CoinList;

public class CoinListQuery : IRequest<CoinListResponse[]> { }