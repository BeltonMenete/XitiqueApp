using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XitiqueAPI.Models.DTOs
{
    public class CreateClientDTO
    {
        public int TotalDays { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? Location { get; set; }
        public decimal DailyAmount { get; set; }
        public decimal TotalAvailable { get; set; }
        public decimal TotalDebt { get; set; }
        public DateTime RegistryDate { get; set; } = DateTime.Now;
    }
}