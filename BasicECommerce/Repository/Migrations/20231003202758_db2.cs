using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class db2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products Table_Baskets_BasketId",
                table: "Products Table");

            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_UserAccounts_UserAccountId",
                table: "Sessions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAccounts_Baskets_BasketId",
                table: "UserAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAccounts",
                table: "UserAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sessions",
                table: "Sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Baskets",
                table: "Baskets");

            migrationBuilder.RenameTable(
                name: "UserAccounts",
                newName: "UserAccount");

            migrationBuilder.RenameTable(
                name: "Sessions",
                newName: "Session");

            migrationBuilder.RenameTable(
                name: "Baskets",
                newName: "Basket");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_Email",
                table: "UserAccount",
                newName: "IX_UserAccount_Email");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_BasketId",
                table: "UserAccount",
                newName: "IX_UserAccount_BasketId");

            migrationBuilder.RenameIndex(
                name: "IX_Sessions_UserAccountId",
                table: "Session",
                newName: "IX_Session_UserAccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAccount",
                table: "UserAccount",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Session",
                table: "Session",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Basket",
                table: "Basket",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products Table_Basket_BasketId",
                table: "Products Table",
                column: "BasketId",
                principalTable: "Basket",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Session_UserAccount_UserAccountId",
                table: "Session",
                column: "UserAccountId",
                principalTable: "UserAccount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAccount_Basket_BasketId",
                table: "UserAccount",
                column: "BasketId",
                principalTable: "Basket",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products Table_Basket_BasketId",
                table: "Products Table");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_UserAccount_UserAccountId",
                table: "Session");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAccount_Basket_BasketId",
                table: "UserAccount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAccount",
                table: "UserAccount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Session",
                table: "Session");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Basket",
                table: "Basket");

            migrationBuilder.RenameTable(
                name: "UserAccount",
                newName: "UserAccounts");

            migrationBuilder.RenameTable(
                name: "Session",
                newName: "Sessions");

            migrationBuilder.RenameTable(
                name: "Basket",
                newName: "Baskets");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccount_Email",
                table: "UserAccounts",
                newName: "IX_UserAccounts_Email");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccount_BasketId",
                table: "UserAccounts",
                newName: "IX_UserAccounts_BasketId");

            migrationBuilder.RenameIndex(
                name: "IX_Session_UserAccountId",
                table: "Sessions",
                newName: "IX_Sessions_UserAccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAccounts",
                table: "UserAccounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sessions",
                table: "Sessions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Baskets",
                table: "Baskets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products Table_Baskets_BasketId",
                table: "Products Table",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_UserAccounts_UserAccountId",
                table: "Sessions",
                column: "UserAccountId",
                principalTable: "UserAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAccounts_Baskets_BasketId",
                table: "UserAccounts",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id");
        }
    }
}
