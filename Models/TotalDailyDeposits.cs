namespace XitiqueAPI.Models
{
    public class TotalDailyDeposits
    {
        public byte[] Id { get; set; } = Ulid.NewUlid().ToByteArray();
        public decimal Amount { get; set; }
    }
}