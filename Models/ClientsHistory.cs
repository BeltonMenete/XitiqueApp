namespace XitiqueAPI.Models
{
    public class ClientsHistory
    {
        public Ulid Id { get; set; }
        public Ulid ClientId { get; set; }
        public DateTime DepositDate { get; set; }
        public decimal TotalDeposited { get; set; }
    }
}