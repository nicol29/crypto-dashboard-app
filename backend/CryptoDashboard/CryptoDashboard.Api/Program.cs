using CryptoDashboard.Api.Models;
using CryptoDashboard.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.Configure<BinanceOptions>(builder.Configuration.GetSection(BinanceOptions.ConfigKey));
builder.Services.AddHostedService<BinanceWorkerService>();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/coinprice", () =>
    {
        
    })
    .WithName("GetCoinPrice");

app.Run();
