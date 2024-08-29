using Microsoft.EntityFrameworkCore;
using XitiqueAPI.Models;

namespace XitiqueAPI;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    DbSet<Loan> Loans { get; set; }
    DbSet<Client> Clients { get; set; }
    DbSet<Transaction> Transactions { get; set; }
    DbSet<DailyDeposit> DailyDeposits { get; set; }
    DbSet<TotalDailyDeposits> TotalDailyDeposits { get; set; }
    DbSet<TotalAllClientsBalance> TotalAllClientsBalances { get; set; }
}