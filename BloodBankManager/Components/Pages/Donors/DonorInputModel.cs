using System.ComponentModel.DataAnnotations;

namespace BloodBankManager.Components.Pages.Donors
{
    public class DonorInputModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Full name required")]
        [MaxLength(50, ErrorMessage = "Max {1}")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email required")]
        [EmailAddress(ErrorMessage = "Invalid email")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Date of birth required")]
        public DateTime DateOfBirth { get; set; }
                
        public string Gender { get; set; } = null!;

        [Required(ErrorMessage = "Weight required")]
        public double Weight { get; set; }

        [Required(ErrorMessage = "Blood ABO type required")]
        public string BloodAboType { get; set; } = null!;

        [Required(ErrorMessage = "Rh Factor required")]
        public string RhFactor { get; set; } = null!;

        public string? Observation { get; set; }
    }
}
