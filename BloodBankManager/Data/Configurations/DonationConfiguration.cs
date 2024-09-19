using BloodBankManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BloodBankManager.Data.Configurations
{
    public class DonationConfiguration : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder.ToTable("Donations");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DonorId)
                .IsRequired();

            builder.Property(x => x.QuantityMl)
                .IsRequired(true)
                .HasColumnType("INT");

            builder.HasOne(d => d.Donor)
                .WithMany(x => x.Donations)
                .HasForeignKey(d => d.DonorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
