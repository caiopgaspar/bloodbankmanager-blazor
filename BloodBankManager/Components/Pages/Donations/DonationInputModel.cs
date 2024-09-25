using BloodBankManager.Models;
using System.ComponentModel.DataAnnotations;

namespace BloodBankManager.InputModels
{
    public class DonationInputModel
    {
        [Required(ErrorMessage = "Donor is required")]
        public Donor SelectedDonor { get; set; }

        [Required(ErrorMessage = "Donation date is required")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format")]
        public DateTime? DonationDate { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(400, 450, ErrorMessage = "Quantity must be between 400ml and 450ml")]
        public int QuantityML { get; set; }  

    }
}
