using BloodBankManager.Enums;

namespace BloodBankManager.Models
{
    public class BloodStock
    {
        public int Id { get; set; }
        public BloodAboTypeEnum BloodAboType { get; set; }
        public RhFactorEnum RhFactor { get; set; }
        public int QuantityMl { get; set; }
    }
}
