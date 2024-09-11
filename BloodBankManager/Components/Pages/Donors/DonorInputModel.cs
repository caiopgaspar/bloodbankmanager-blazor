using BloodBankManager.Enums;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

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

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Not a valid date time")]               
        public DateTime DateOfBirth { get; set; }

        public GenderEnum Gender { get; set; }

        [Required(ErrorMessage = "Weight required")]
        public double Weight { get; set; }

        [Required(ErrorMessage = "Blood ABO type required")]
        //[RegularExpression("([1-9][0-9]*)", ErrorMessage = "Invalid selected value")]
        public BloodAboTypeEnum BloodAboType { get; set; }

        [Required(ErrorMessage = "Rh Factor required")]
        //[RegularExpression("([1-9][0-9]*)", ErrorMessage = "Invalid selected value")]
        public RhFactorEnum RhFactor { get; set; } 

        public string? Observation { get; set; }
    }
}
