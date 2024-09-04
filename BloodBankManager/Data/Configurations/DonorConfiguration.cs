﻿using BloodBankManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BloodBankManager.Data.Configurations
{
    public class DonorConfiguration : IEntityTypeConfiguration<Donor>
    {
        public void Configure(EntityTypeBuilder<Donor> builder)
        {
            builder.ToTable("Donors");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.FullName)
                .IsRequired(true)
                .HasColumnType("VARCHAR(50)");

            builder.Property(d => d.Email)
                .IsRequired(true)
                .HasColumnType("VARCHAR(50)");

            builder.Property(d => d.DateOfBirth)
                .IsRequired(true)
                .HasColumnType("VARCHAR(50)");

            builder.Property(d => d.Gender)
                .IsRequired(true)
                .HasColumnType("CHAR(1)");

            builder.Property(d => d.Weight)
                .IsRequired(true)
                .HasColumnType("NVARCHAR(5)");

            builder.Property(d => d.BloodAboType)
                .IsRequired(true)
                .HasColumnType("CHAR(1)");

            builder.Property(d => d.RhFactor)
                .IsRequired(true)
                .HasColumnType("VARCHAR(8)");

            builder.Property(d => d.Observation)
                .IsRequired(false)
                .HasColumnType("VARCHAR(100)");

            builder.HasMany(d => d.Donations)
                .WithOne(d => d.Donor)
                .HasForeignKey(d => d.DonorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
