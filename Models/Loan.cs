namespace XitiqueAPI.Models
{
    public class Loan
    {
        public Guid Id { get; set; }
        public Ulid ClientId { get; set; }
        public DateTime DevolutionData { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}