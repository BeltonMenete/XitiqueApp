namespace XitiqueAPI.Models
{
    public class DailyDeposit
    {
        public byte[] Id { get; set; } = Ulid.NewUlid().ToByteArray();
        public decimal DailyAccumulated { get; set; }
    }
}

