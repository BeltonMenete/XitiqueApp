namespace XitiqueAPI.Models
{
    public class Loan
    {
        public byte[] Id { get; set; } = Ulid.NewUlid().ToByteArray();
        public Guid ClientId { get; set; }
        public DateTime DevolutionData { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}