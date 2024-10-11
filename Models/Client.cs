using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace XitiqueAPI.Models
{
    // Client details
    public class Client
    {
        [Required]
        public byte[] Id { get; set; } = Ulid.NewUlid().ToByteArray();
        public int TotalDays { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? Location { get; set; }
        public decimal DailyAmount { get; set; }
        public decimal TotalAvailable { get; set; }
        public decimal TotalDebt { get; set; }
        public required string Password { get; set; } = string.Empty;
        public DateTime RegistryDate { get; set; } = DateTime.Now;
        // public Ulid ClientHistoryId { get; set; }

    }
}