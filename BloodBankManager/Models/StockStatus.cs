namespace BloodBankManager.Models
{
    public class StockStatus
    {
        public int Id { get; set; }
        public string BloodAboType { get; set; }
        public string RhFactor { get; set; }
        public int Quantity { get; set; }
        public int Capacity { get; set; }
    }
}
