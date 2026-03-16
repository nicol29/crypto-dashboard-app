using CryptoDashboard.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CryptoDashboard.Infrastructure.Context;

public class CryptoDashboardContext(DbContextOptions<CryptoDashboardContext> options) : DbContext(options)
{
    public DbSet<PriceHistory> PriceHistory { get; set; }
}