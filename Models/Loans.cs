namespace XitiqueAPI.Models
{
    public class Loans
    {
        public int Id { get; set; }
        public Ulid PublicId { get; set; }

        public DateTime DevolutionData { get; set; }
    }
}