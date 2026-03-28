namespace CryptoDashboard.Api.Integrations.CoinGecko;

public class CoinGeckoClient(HttpClient httpClient)
{
    public async Task<string> GetCoinsAsync(CancellationToken cancellationToken)
    {
        return await 
            SendAsync($"/api/v3/coins/markets?vs_currency=eur&price_change_percentage=24h&order=market_cap_desc&per_page=10&page=1&sparkline=true", 
                cancellationToken);
    }

    private async Task<string> SendAsync(string url, CancellationToken cancellationToken)
    {
        var response = await httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }
}