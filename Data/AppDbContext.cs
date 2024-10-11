using Microsoft.EntityFrameworkCore;
using XitiqueAPI.Models;

namespace XitiqueAPI.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<DailyDeposit> DailyDeposits { get; set; }
    public DbSet<Loan> Loans { get; set; }
    public DbSet<TotalAllClientsBalance> TotalAllClientsBalance { get; set; }
    public DbSet<TotalDailyDeposits> TotalDailyDeposits { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
}
