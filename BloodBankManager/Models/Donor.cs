using BloodBankManager.Enums;

namespace BloodBankManager.Models
{
    public class Donor
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public GenderEnum? Gender { get; set; }
        public double Weight { get; set; }
        public BloodAboTypeEnum BloodAboType { get; set; }
        public RhFactorEnum RhFactor { get; set; }
        public string? Observation { get; set; }
        public List<Donation> Donations { get; set; }
        //public Address Address { get; set; }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth.Date > today.AddYears(-age)) 
                    age--;
                return age;
            }
        }
    }
}
