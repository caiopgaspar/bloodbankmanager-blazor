namespace BloodBankManager.Models
{
    public class Donor
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = null!;
        public double Weight { get; set; }
        public string BloodAboType { get; set; } = null!;
        public string RhFactor { get; set; } = null!;
        public string? Observation { get; set; }
        public List<Donation> Donations { get; set; }
        //public Address Address { get; set; }
    }
}
