namespace XitiqueAPI.Models
{
    public class Transaction
    {
        public Ulid TransactionId { get; set; }
        public Ulid ClientID { get; set; }
        public decimal ClientAmount { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}