using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodBankManager.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDonation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DonorBloodAboType",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "DonorRhFactor",
                table: "Donations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0001-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c19c5bd-ab3d-420f-9f9c-389afb9de3db", "AQAAAAIAAYagAAAAELMF8PwGxBU1yV1nSQYZ+PKXbYwAXHc/NgwvRtaMa3z+IZ9Iw4KeK2fQTwm27YlbKQ==", "6b197fa1-6dc8-4a54-9d6f-63bcb65b5370" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DonorBloodAboType",
                table: "Donations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DonorRhFactor",
                table: "Donations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0001-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e774463-6246-404f-800f-4fc78d83f6e1", "AQAAAAIAAYagAAAAEJhHhAxUL1owqIn6ILPq1Sa6GUWc+hvJeRwEofGygpFJK2glWA4BMko2h99uxI9U9Q==", "80ce5c9f-9d26-4a27-9135-f17f268e7685" });
        }
    }
}
