using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xitiqueAPI.Models
{
    public class Client
    {
        public byte[] Id { get; set; } = Ulid.NewUlid().ToByteArray();
        public string? Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}