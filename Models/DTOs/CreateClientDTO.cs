using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xitiqueAPI.Models.DTOs
{
    public class CreateClientDTO
    {
        public string? Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}