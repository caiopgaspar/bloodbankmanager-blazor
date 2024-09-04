namespace BloodBankManager.Models
{
    public class BloodStock
    {
        public int Id { get; set; }
        public string BloodAboType { get; set; } = null!;
        public string RhFactor { get; set; } = null!;
        public int QuantityMl { get; set; }
    }
}
