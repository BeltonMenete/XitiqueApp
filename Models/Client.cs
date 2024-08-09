using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace XitiqueAPI.Models
{
    // Client details
    public class Client
    {
        public Guid ClientId { get; set; }
        public int TotalDays { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Location { get; set; }
        public decimal DailyAmount { get; set; }
        public decimal TotalAvailable { get; set; }
        public decimal TotalDebt { get; set; }
        public required string Password { get; set; } = string.Empty;
        public DateTime RegistryDate { get; set; } = DateTime.Now;
        // public Ulid ClientHistoryId { get; set; }

    }
}