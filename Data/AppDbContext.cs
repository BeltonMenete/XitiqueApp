using Microsoft.EntityFrameworkCore;
using XitiqueAPI.Models;

namespace XitiqueAPI.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Client> Clients { get; set; }
}
