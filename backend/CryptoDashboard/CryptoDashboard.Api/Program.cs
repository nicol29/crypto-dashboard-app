using CryptoDashboard.Api.Services;
using CryptoDashboard.Infrastructure.Context;
using CryptoDashboard.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddDbContextPool<CryptoDashboardContext>(options => 
    options
        .UseNpgsql(builder.Configuration["DBConnectionString"])
        .UseSnakeCaseNamingConvention());
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
