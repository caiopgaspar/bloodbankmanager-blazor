using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodBankManager.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGenderAndBloodAboType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BloodAboType",
                table: "Donors",
                type: "VARCHAR(2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "CHAR(1)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0001-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30ced073-de1a-401d-8462-bc2413a7b0f1", "AQAAAAIAAYagAAAAELZHj3yzDt53UvhPjwBlFemzXvUQZGMecUkm3lFMqJ5XYTR/6WmqVd30PBGTZcmvog==", "1823aaa9-14ec-4f6b-a071-62e7f30d5d03" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BloodAboType",
                table: "Donors",
                type: "CHAR(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(2)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0001-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad31d80f-a0d4-4edd-a3b7-28dc514a5dee", "AQAAAAIAAYagAAAAECXtk0o0yqKz0d1dxvilNYuuQ9kkFXrp1oeUld+OJ6JsN+8L0t2c0PSzHcYL+EHOOw==", "dfbc5702-2dc0-4b92-adf6-051d41b73a21" });
        }
    }
}
