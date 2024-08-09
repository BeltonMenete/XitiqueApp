

using Microsoft.EntityFrameworkCore;
using XitiqueAPI.Models;

namespace XitiqueAPI.ApplicationDbContext;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    DbSet<Client> Clients { get; set; }
    DbSet<Transaction> Transactions { get; set; }
    DbSet<DailyDeposit> DailyDeposits { get; set; }
    DbSet<TotalDailyDeposits> TotalDailyDeposits { get; set; }
    DbSet<TotalAllClientsBalance> TotalAllClientsBalances { get; set; }
}