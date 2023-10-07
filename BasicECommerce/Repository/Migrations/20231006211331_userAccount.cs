using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class userAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAccounts_Sessions_SessionId",
                table: "UserAccounts");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "GuestAccounts");

            migrationBuilder.DropIndex(
                name: "IX_UserAccounts_SessionId",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "GuestAccountId",
                table: "Carts");

            migrationBuilder.AddColumn<bool>(
                name: "IsGuest",
                table: "UserAccounts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLoggedIn",
                table: "UserAccounts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Carts",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsGuest",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "IsLoggedIn",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Carts");

            migrationBuilder.AddColumn<int>(
                name: "SessionId",
                table: "UserAccounts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GuestAccountId",
                table: "Carts",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GuestAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CartId = table.Column<int>(type: "integer", nullable: true),
                    SessionId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuestAccounts_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GuestAccountId = table.Column<int>(type: "integer", nullable: true),
                    UserAccountId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_GuestAccounts_GuestAccountId",
                        column: x => x.GuestAccountId,
                        principalTable: "GuestAccounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_SessionId",
                table: "UserAccounts",
                column: "SessionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GuestAccounts_CartId",
                table: "GuestAccounts",
                column: "CartId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_GuestAccountId",
                table: "Sessions",
                column: "GuestAccountId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAccounts_Sessions_SessionId",
                table: "UserAccounts",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id");
        }
    }
}
