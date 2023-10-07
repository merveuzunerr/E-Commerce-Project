using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class Basket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products Table_BasketId",
                table: "Products Table");

            migrationBuilder.CreateIndex(
                name: "IX_Products Table_BasketId",
                table: "Products Table",
                column: "BasketId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products Table_BasketId",
                table: "Products Table");

            migrationBuilder.CreateIndex(
                name: "IX_Products Table_BasketId",
                table: "Products Table",
                column: "BasketId");
        }
    }
}
