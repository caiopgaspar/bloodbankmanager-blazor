using BloodBankManager.Data;

namespace BloodBankManager.Models
{
    public class User : ApplicationUser
    {
        public string Name { get; set; } = null!;
    }
}
