using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace XitiqueAPI.Models
{
    // Each Client details
    public class Client
    {
        public Ulid ClientId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Location { get; set; }
        public decimal DailyAmount { get; set; }
        public decimal TotalAvailable { get; set; }
        public decimal TotalDebt { get; set; }
        public required string Password { get; set; }
        public DateTime RegistryDate { get; set; }
        public Ulid ClientHistoryId { get; set; }

    }
}