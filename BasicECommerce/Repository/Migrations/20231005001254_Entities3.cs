using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class Entities3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sub Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "SubCategoryName",
                value: "IOS Telefonlar");

            migrationBuilder.UpdateData(
                table: "Sub Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "SubCategoryName",
                value: "Samsung Telefonlar");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sub Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "SubCategoryName",
                value: "Iphone");

            migrationBuilder.UpdateData(
                table: "Sub Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "SubCategoryName",
                value: "Samsung");
        }
    }
}
