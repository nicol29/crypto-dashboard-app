using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using CryptoDashboard.Api.Configurations;
using CryptoDashboard.Api.Integrations.Binance.Dtos;
using Microsoft.Extensions.Options;

namespace CryptoDashboard.Api.Services;

public class BinanceWorkerService : BackgroundService
{
    private readonly ILogger<BinanceWorkerService> _logger;
    private readonly BinanceOptions _binanceOptions;
    private readonly JsonSerializerOptions _jsonSerializerOptions;
    private readonly ClientWebSocket _clientWebSocket;

    public BinanceWorkerService(ILogger<BinanceWorkerService> logger, IOptions<BinanceOptions> binanceOptions)
    {
        _logger = logger;
        _binanceOptions = binanceOptions.Value;
        _jsonSerializerOptions = new JsonSerializerOptions {
            NumberHandling = JsonNumberHandling.AllowReadingFromString
        };
        _clientWebSocket = new ClientWebSocket();
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Worker started at {time}", DateTimeOffset.Now);
        
        await _clientWebSocket.ConnectAsync(new Uri(_binanceOptions.WebSocketUrl), stoppingToken);
        
        while (!stoppingToken.IsCancellationRequested && _clientWebSocket.State == WebSocketState.Open)
        {
            var buffer = new byte[1024];
            var result = await _clientWebSocket.ReceiveAsync(buffer, stoppingToken);

            var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
            var tickerObj = JsonSerializer.Deserialize<BinanceTickerMessage>(message, _jsonSerializerOptions);
            
            _logger.LogInformation("Message: {message}", message);
        }
    }
}