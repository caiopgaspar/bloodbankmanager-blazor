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

            builder.Property(x => x.DonationDate)
                .IsRequired();

            builder.Property(x => x.QuantityMl)
                .IsRequired(true)
                .HasColumnType("NVARCHAR(5)");

            builder.Property(x => x.Donor);

            builder.HasOne(d => d.Donor)
                .WithMany(x => x.Donations)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
