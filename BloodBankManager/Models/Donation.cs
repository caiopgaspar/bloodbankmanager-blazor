﻿namespace BloodBankManager.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public int DonorId { get; set; }
        public DateTime DonationDate { get; set; } = DateTime.Today;
        public int QuantityMl { get; set; }

        public Donor Donor { get; set; }
    }
}
