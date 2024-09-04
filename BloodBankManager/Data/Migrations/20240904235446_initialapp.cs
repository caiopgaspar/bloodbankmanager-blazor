using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodBankManager.Migrations
{
    /// <inheritdoc />
    public partial class initialapp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Donors",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0001-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e814b6a8-5ddc-4cf1-abf2-0b1e41da7513", "AQAAAAIAAYagAAAAEJMvn3gE6MiTTOFJh2cCcOf0yGF+sv3NAVZMwgKYTVGd0r4eDZwKjFFxOy+h8MENlw==", "faa53055-e2a2-493f-b8b9-4e7de8e029c2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Donors",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0001-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c92d6368-e137-40c7-b950-fedb1e531318", "AQAAAAIAAYagAAAAEDY3tBE6sRj5PAkwAj/GcZ6DD+1ifGkwb+8W4e2Xyd6/E/nfofcvBm8bnFc9Se0LWg==", "6a48c47c-e1c7-4748-b5f8-9f523b0d3d98" });
        }
    }
}
