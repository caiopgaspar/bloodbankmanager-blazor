using BloodBankManager.Enums;
using BloodBankManager.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BloodBankManager.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;
        public DbInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;            
        }

        internal void seed()
        {
            _modelBuilder.Entity<IdentityRole>().HasData
            (
                new IdentityRole
                {
                    Id = "0001",
                    Name = "User",
                    NormalizedName = "USER"                    
                }
            );

            var hasher = new PasswordHasher<IdentityUser>();

            _modelBuilder.Entity<User>().HasData
            (
                new User
                {
                    Id = "0001-1",
                    Name = "Admin",
                    Email = "admin@bloodbankmanager.com",
                    UserName = "admin",
                    NormalizedEmail = "ADMIN@BLOODBANKMANAGER.COM",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = hasher.HashPassword(null, "12345678")
                }
            );

            _modelBuilder.Entity<IdentityUserRole<string>>().HasData
            (
                new IdentityUserRole<string>
                {
                    RoleId = "0001",
                    UserId = "0001-1"
                }
            );

            _modelBuilder.Entity<BloodStock>().HasData
            (
                new BloodStock { Id = 1, BloodAboType = BloodAboTypeEnum.A, RhFactor = RhFactorEnum.positive, QuantityMl = 0 },
                new BloodStock { Id = 2, BloodAboType = BloodAboTypeEnum.A, RhFactor = RhFactorEnum.negative, QuantityMl = 0 },
                new BloodStock { Id = 3, BloodAboType = BloodAboTypeEnum.B, RhFactor = RhFactorEnum.positive, QuantityMl = 0 },
                new BloodStock { Id = 4, BloodAboType = BloodAboTypeEnum.B, RhFactor = RhFactorEnum.negative, QuantityMl = 0 },
                new BloodStock { Id = 5, BloodAboType = BloodAboTypeEnum.AB, RhFactor = RhFactorEnum.positive, QuantityMl = 0 },
                new BloodStock { Id = 6, BloodAboType = BloodAboTypeEnum.AB, RhFactor = RhFactorEnum.negative, QuantityMl = 0 },
                new BloodStock { Id = 7, BloodAboType = BloodAboTypeEnum.O, RhFactor = RhFactorEnum.positive, QuantityMl = 0 },
                new BloodStock { Id = 8, BloodAboType = BloodAboTypeEnum.O, RhFactor = RhFactorEnum.negative, QuantityMl = 0 }
            );
        }
    }
}
