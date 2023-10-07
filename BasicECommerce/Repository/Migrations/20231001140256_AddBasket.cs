using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddBasket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BasketId",
                table: "UserAccounts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BasketId",
                table: "Products Table",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    UserAccountId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 1,
                column: "BasketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 2,
                column: "BasketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 3,
                column: "BasketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 4,
                column: "BasketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 5,
                column: "BasketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 6,
                column: "BasketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 7,
                column: "BasketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 8,
                column: "BasketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 9,
                column: "BasketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 10,
                column: "BasketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 11,
                column: "BasketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 12,
                column: "BasketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 13,
                column: "BasketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 14,
                column: "BasketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 15,
                column: "BasketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 16,
                column: "BasketId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_BasketId",
                table: "UserAccounts",
                column: "BasketId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products Table_BasketId",
                table: "Products Table",
                column: "BasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products Table_Baskets_BasketId",
                table: "Products Table",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAccounts_Baskets_BasketId",
                table: "UserAccounts",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products Table_Baskets_BasketId",
                table: "Products Table");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAccounts_Baskets_BasketId",
                table: "UserAccounts");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_UserAccounts_BasketId",
                table: "UserAccounts");

            migrationBuilder.DropIndex(
                name: "IX_Products Table_BasketId",
                table: "Products Table");

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "Products Table");
        }
    }
}
