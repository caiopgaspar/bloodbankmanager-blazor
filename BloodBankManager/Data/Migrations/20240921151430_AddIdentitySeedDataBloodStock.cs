using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BloodBankManager.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentitySeedDataBloodStock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0001-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd79ae63-25c5-4561-8067-79ccd2ba9830", "AQAAAAIAAYagAAAAEGnviSZZQWJ/cqAEbSRFeL0v6OPp7btIVreGYiuxvg2xmiLroaivNLW/iW0HpEBApw==", "adf4647c-76f9-433a-81d4-878a8856b788" });

            migrationBuilder.InsertData(
                table: "BloodStock",
                columns: new[] { "Id", "BloodAboType", "QuantityMl", "RhFactor" },
                values: new object[,]
                {
                    { 1, "A", 0, "positive" },
                    { 2, "A", 0, "negative" },
                    { 3, "B", 0, "positive" },
                    { 4, "B", 0, "negative" },
                    { 5, "AB", 0, "positive" },
                    { 6, "AB", 0, "negative" },
                    { 7, "O", 0, "positive" },
                    { 8, "O", 0, "negative" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BloodStock",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BloodStock",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BloodStock",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BloodStock",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BloodStock",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BloodStock",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BloodStock",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BloodStock",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0001-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2906751c-ec7f-44da-94ec-c46f81f36e2f", "AQAAAAIAAYagAAAAEJYLmMDzqhS1PwPRwlHfGpYsV/GuxHrdWCYr5zUXs6Aj3kWu46NKF+O2kzHJJB64NA==", "4d13f387-bd8a-4491-9834-30b072ea2d6f" });
        }
    }
}
