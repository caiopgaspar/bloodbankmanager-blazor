using BloodBankManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BloodBankManager.Data.Configurations
{
    public class BloodStockConfiguration : IEntityTypeConfiguration<BloodStock>
    {
        public void Configure(EntityTypeBuilder<BloodStock> builder)
        {
            builder.ToTable("BloodStock");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.BloodAboType)
                .IsRequired()
                .HasColumnType("VARCHAR(2)");

            builder.Property(b => b.RhFactor)
                .IsRequired()
                .HasColumnType("VARCHAR(8)");

            builder.Property(b => b.QuantityMl)
                .IsRequired()
                .HasColumnType("NVARCHAR(10)");
        }
    }
}
