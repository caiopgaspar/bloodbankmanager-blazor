using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodBankManager.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBloodStockConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RhFactor",
                table: "BloodStock",
                type: "VARCHAR(8)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "CHAR(1)");

            migrationBuilder.AlterColumn<int>(
                name: "QuantityMl",
                table: "BloodStock",
                type: "INT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(10)");

            migrationBuilder.AlterColumn<string>(
                name: "BloodAboType",
                table: "BloodStock",
                type: "VARCHAR(2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "CHAR(1)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0001-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2906751c-ec7f-44da-94ec-c46f81f36e2f", "AQAAAAIAAYagAAAAEJYLmMDzqhS1PwPRwlHfGpYsV/GuxHrdWCYr5zUXs6Aj3kWu46NKF+O2kzHJJB64NA==", "4d13f387-bd8a-4491-9834-30b072ea2d6f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RhFactor",
                table: "BloodStock",
                type: "CHAR(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(8)");

            migrationBuilder.AlterColumn<string>(
                name: "QuantityMl",
                table: "BloodStock",
                type: "NVARCHAR(10)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<string>(
                name: "BloodAboType",
                table: "BloodStock",
                type: "CHAR(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(2)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0001-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c19c5bd-ab3d-420f-9f9c-389afb9de3db", "AQAAAAIAAYagAAAAELMF8PwGxBU1yV1nSQYZ+PKXbYwAXHc/NgwvRtaMa3z+IZ9Iw4KeK2fQTwm27YlbKQ==", "6b197fa1-6dc8-4a54-9d6f-63bcb65b5370" });
        }
    }
}
