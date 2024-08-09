using Microsoft.EntityFrameworkCore;
using XitiqueAPI.Models;

namespace XitiqueAPI.ApplicationDbContext
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<DailyDeposit> DailyDeposits { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TotalAllClientsBalance> TotalClientsBalances { get; set; }
    }
}