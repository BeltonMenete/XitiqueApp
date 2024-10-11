namespace XitiqueAPI.Models
{
    public class Transaction
    {
        public byte[] Id { get; set; } = Ulid.NewUlid().ToByteArray();
        public Guid ClientID { get; set; }
        public decimal ClientAmount { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}