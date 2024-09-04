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
                    UserName = "admin@bloodbankmanager.com",
                    NormalizedEmail = "ADMIN@BLOODBANKMANAGER.COM",
                    NormalizedUserName = "ADMIN@BLOODBANKMANAGER.COM",
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
        }
    }
}
