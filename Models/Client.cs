using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace XitiqueAPI.Models
{
    public class Client
    {
        public Ulid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Location { get; set; }
        public decimal DailyAmount { get; set; }
        public decimal TotalAvailable { get; set; }
        public decimal TotalDebt { get; set; }
        public required string Password { get; set; }
        public Ulid ClientHistory_Id { get; set; }

    }
}