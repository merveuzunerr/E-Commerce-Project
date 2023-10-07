using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class Entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products Features Table_Products Table_ProductId",
                table: "Products Features Table");

            migrationBuilder.DropForeignKey(
                name: "FK_Products Table_Basket_BasketId",
                table: "Products Table");

            migrationBuilder.DropForeignKey(
                name: "FK_Products Table_Sub Categories Table_SubCategoryId",
                table: "Products Table");

            migrationBuilder.DropForeignKey(
                name: "FK_Sub Categories Table_Categories Table_CategoryId",
                table: "Sub Categories Table");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "UserAccount");

            migrationBuilder.DropTable(
                name: "Basket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sub Categories Table",
                table: "Sub Categories Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products Table",
                table: "Products Table");

            migrationBuilder.DropIndex(
                name: "IX_Products Table_BasketId",
                table: "Products Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products Features Table",
                table: "Products Features Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories Table",
                table: "Categories Table");

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "Products Table");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Categories Table");

            migrationBuilder.RenameTable(
                name: "Sub Categories Table",
                newName: "Sub Categories");

            migrationBuilder.RenameTable(
                name: "Products Table",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Products Features Table",
                newName: "Products Features");

            migrationBuilder.RenameTable(
                name: "Categories Table",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "SubName",
                table: "Sub Categories",
                newName: "SubCategoryName");

            migrationBuilder.RenameIndex(
                name: "IX_Sub Categories Table_CategoryId",
                table: "Sub Categories",
                newName: "IX_Sub Categories_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products Table_SubCategoryId",
                table: "Products",
                newName: "IX_Products_SubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products Features Table_ProductId",
                table: "Products Features",
                newName: "IX_Products Features_ProductId");

            migrationBuilder.RenameColumn(
                name: "MainCategory",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(16,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "ParentCategoryId",
                table: "Categories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sub Categories",
                table: "Sub Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products Features",
                table: "Products Features",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ParentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentCategoryName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentCategories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "ParentCategoryId" },
                values: new object[] { "Beyaz Eşya", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "ParentCategoryId" },
                values: new object[] { "Bilgisayar", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "ParentCategoryId" },
                values: new object[] { "Küçük Ev Aletleri", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "ParentCategoryId" },
                values: new object[] { "Telefon", 1 });

            migrationBuilder.InsertData(
                table: "ParentCategories",
                columns: new[] { "Id", "ParentCategoryName" },
                values: new object[,]
                {
                    { 1, "Elektronik" },
                    { 2, "Elektronik" },
                    { 3, "Elektronik" },
                    { 4, "Elektronik" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_ParentCategories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId",
                principalTable: "ParentCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sub Categories_SubCategoryId",
                table: "Products",
                column: "SubCategoryId",
                principalTable: "Sub Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products Features_Products_ProductId",
                table: "Products Features",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sub Categories_Categories_CategoryId",
                table: "Sub Categories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_ParentCategories_ParentCategoryId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sub Categories_SubCategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products Features_Products_ProductId",
                table: "Products Features");

            migrationBuilder.DropForeignKey(
                name: "FK_Sub Categories_Categories_CategoryId",
                table: "Sub Categories");

            migrationBuilder.DropTable(
                name: "ParentCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sub Categories",
                table: "Sub Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products Features",
                table: "Products Features");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ParentCategoryId",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Sub Categories",
                newName: "Sub Categories Table");

            migrationBuilder.RenameTable(
                name: "Products Features",
                newName: "Products Features Table");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Products Table");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categories Table");

            migrationBuilder.RenameColumn(
                name: "SubCategoryName",
                table: "Sub Categories Table",
                newName: "SubName");

            migrationBuilder.RenameIndex(
                name: "IX_Sub Categories_CategoryId",
                table: "Sub Categories Table",
                newName: "IX_Sub Categories Table_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products Features_ProductId",
                table: "Products Features Table",
                newName: "IX_Products Features Table_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products Table",
                newName: "IX_Products Table_SubCategoryId");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories Table",
                newName: "MainCategory");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products Table",
                type: "numeric(16,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products Table",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "BasketId",
                table: "Products Table",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Categories Table",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sub Categories Table",
                table: "Sub Categories Table",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products Features Table",
                table: "Products Features Table",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products Table",
                table: "Products Table",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories Table",
                table: "Categories Table",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Basket",
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
                    table.PrimaryKey("PK_Basket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BasketId = table.Column<int>(type: "integer", nullable: true),
                    City = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true, defaultValue: true),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAccount_Basket_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Basket",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserAccountId = table.Column<int>(type: "integer", nullable: false),
                    TokenExpiration = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Session_UserAccount_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "UserAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MainCategory", "Name" },
                values: new object[] { "Elektronik", "Beyaz Eşya" });

            migrationBuilder.UpdateData(
                table: "Categories Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MainCategory", "Name" },
                values: new object[] { "Elektronik", "Bilgisayar" });

            migrationBuilder.UpdateData(
                table: "Categories Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MainCategory", "Name" },
                values: new object[] { "Elektronik", "Küçük Ev Aletleri" });

            migrationBuilder.UpdateData(
                table: "Categories Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MainCategory", "Name" },
                values: new object[] { "Elektronik", "Telefon" });

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
                name: "IX_Products Table_BasketId",
                table: "Products Table",
                column: "BasketId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Session_UserAccountId",
                table: "Session",
                column: "UserAccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAccount_BasketId",
                table: "UserAccount",
                column: "BasketId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAccount_Email",
                table: "UserAccount",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products Features Table_Products Table_ProductId",
                table: "Products Features Table",
                column: "ProductId",
                principalTable: "Products Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products Table_Basket_BasketId",
                table: "Products Table",
                column: "BasketId",
                principalTable: "Basket",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products Table_Sub Categories Table_SubCategoryId",
                table: "Products Table",
                column: "SubCategoryId",
                principalTable: "Sub Categories Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sub Categories Table_Categories Table_CategoryId",
                table: "Sub Categories Table",
                column: "CategoryId",
                principalTable: "Categories Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
