namespace XitiqueAPI.Models
{
    // This a total monthly Balance for all Clients
    public class TotalAllClientsBalance
    {
        public byte[] Id { get; set; } = Ulid.NewUlid().ToByteArray();
        public decimal TotalAvailable { get; set; }
        public decimal TotalDebt { get; set; }
    }
}