namespace CryptoDashboard.Api.Integrations.Binance;

public class BinanceClient(HttpClient httpClient)
{
    private readonly HttpClient _httpClient = httpClient;
    
    public async Task<string> GetTickerAsync(string ticker)
    {
        return await SendAsync($"api/v3/ticker?symbol={ticker}");
    }

    private async Task<string> SendAsync(string url)
    {
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }
}