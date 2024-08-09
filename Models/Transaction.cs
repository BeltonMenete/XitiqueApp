namespace XitiqueAPI.Models
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public Guid ClientID { get; set; }
        public decimal ClientAmount { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}