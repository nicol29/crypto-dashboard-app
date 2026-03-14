using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using CryptoDashboard.Api.Models;

namespace CryptoDashboard.Api.Services;

public class BinanceWorkerService(ILogger<BinanceWorkerService> logger) : BackgroundService
{
    private readonly ILogger<BinanceWorkerService> _logger = logger;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Worker started at {time}", DateTimeOffset.Now);
        
        var client = new ClientWebSocket();
        await client.ConnectAsync(new Uri("wss://stream.binance.com:9443/ws/btceur@ticker"), stoppingToken);
        
        while (!stoppingToken.IsCancellationRequested && client.State == WebSocketState.Open)
        {
            // _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            var buffer = new byte[1024];
            var result = await client.ReceiveAsync(buffer, stoppingToken);

            var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
            var messageObj = JsonSerializer.Deserialize<BinanceTickerMessage>(message);
            _logger.LogInformation("Message: {message}", message);
        }
    }
}