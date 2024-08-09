namespace XitiqueAPI.Models
{
    // This a total monthly Balance for all Clients
    public class TotalAllClientsBalance
    {
        public Guid Id { get; set; }
        public decimal TotalAvailable { get; set; }
        public decimal TotalDebt { get; set; }
    }
}