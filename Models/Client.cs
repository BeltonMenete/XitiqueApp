using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xitiqueAPI.Models
{
    public class Client
    {
        public Guid Id { get; set; } = Ulid.NewUlid().ToGuid();
        public string? Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}