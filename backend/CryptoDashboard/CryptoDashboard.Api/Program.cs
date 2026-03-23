using CryptoDashboard.Api.Configurations;
using CryptoDashboard.Api.Extensions;
using CryptoDashboard.Api.Integrations.Binance;
using CryptoDashboard.Api.Integrations.CoinGecko;
using CryptoDashboard.Api.Services;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.Configure<BinanceOptions>(builder.Configuration.GetSection(BinanceOptions.ConfigKey));
builder.Services.Configure<CoinGeckoOptions>(builder.Configuration.GetSection(CoinGeckoOptions.ConfigKey));

builder.Services.AddMediatR((cfg) =>
{
    var mediatROptions = builder.Configuration.GetSection(MediatROptions.ConfigKey).Get<MediatROptions>();
    
    cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly);
    cfg.LicenseKey = mediatROptions?.LicenseKey;
});

builder.Services.AddHttpClient<CoinGeckoClient>(HttpClientNames.CoinGeckoApi, (serviceProvider, client) =>
{
    var coinGeckoOptions = serviceProvider.GetRequiredService<IOptions<CoinGeckoOptions>>().Value;

    client.BaseAddress = new Uri(coinGeckoOptions.ApiUrl);
    client.DefaultRequestHeaders.Add(coinGeckoOptions.HeaderApiKey, coinGeckoOptions.ApiKey);
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});
builder.Services.AddHttpClient<BinanceClient>(HttpClientNames.BinanceApi, (serviceProvider, client) =>
{
    var binanceOptions = serviceProvider.GetRequiredService<IOptions<BinanceOptions>>().Value;

    client.BaseAddress = new Uri(binanceOptions.ApiUrl);
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});
// builder.Services.AddHostedService<BinanceWorkerService>();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.RegisterEndpoints();

app.Run();
