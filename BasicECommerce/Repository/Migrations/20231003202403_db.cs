using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products Futures Table_Products Table_ProductId",
                table: "Products Futures Table");

            migrationBuilder.DropForeignKey(
                name: "FK_Products Table_Categories Table_CategoryId",
                table: "Products Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products Futures Table",
                table: "Products Futures Table");

            migrationBuilder.DropColumn(
                name: "MainCategory",
                table: "Products Table");

            migrationBuilder.RenameTable(
                name: "Products Futures Table",
                newName: "Products Features Table");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products Table",
                newName: "SubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products Table_CategoryId",
                table: "Products Table",
                newName: "IX_Products Table_SubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products Futures Table_ProductId",
                table: "Products Features Table",
                newName: "IX_Products Features Table_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products Features Table",
                table: "Products Features Table",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Sub Categories Table",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SubName = table.Column<string>(type: "text", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub Categories Table", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sub Categories Table_Categories Table_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "LENOVA LEPTOP");

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "HUAWEİ LEPTOP");

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "APPLE LEPTOP");

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "ASUS LEPTOP");

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 10,
                column: "SubCategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 11,
                column: "SubCategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 12,
                column: "SubCategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 13,
                column: "SubCategoryId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 14,
                column: "SubCategoryId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 15,
                column: "SubCategoryId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 16,
                column: "SubCategoryId",
                value: 8);

            migrationBuilder.InsertData(
                table: "Sub Categories Table",
                columns: new[] { "Id", "CategoryId", "SubName" },
                values: new object[,]
                {
                    { 1, 1, "Buzdolabı" },
                    { 2, 2, "Laptop" },
                    { 3, 3, "Kettle" },
                    { 4, 3, "Blender" },
                    { 5, 3, "Tartı" },
                    { 6, 3, "Airfryer" },
                    { 7, 4, "Iphone" },
                    { 8, 4, "Samsung" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sub Categories Table_CategoryId",
                table: "Sub Categories Table",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products Features Table_Products Table_ProductId",
                table: "Products Features Table",
                column: "ProductId",
                principalTable: "Products Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products Table_Sub Categories Table_SubCategoryId",
                table: "Products Table",
                column: "SubCategoryId",
                principalTable: "Sub Categories Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products Features Table_Products Table_ProductId",
                table: "Products Features Table");

            migrationBuilder.DropForeignKey(
                name: "FK_Products Table_Sub Categories Table_SubCategoryId",
                table: "Products Table");

            migrationBuilder.DropTable(
                name: "Sub Categories Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products Features Table",
                table: "Products Features Table");

            migrationBuilder.RenameTable(
                name: "Products Features Table",
                newName: "Products Futures Table");

            migrationBuilder.RenameColumn(
                name: "SubCategoryId",
                table: "Products Table",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products Table_SubCategoryId",
                table: "Products Table",
                newName: "IX_Products Table_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products Features Table_ProductId",
                table: "Products Futures Table",
                newName: "IX_Products Futures Table_ProductId");

            migrationBuilder.AddColumn<string>(
                name: "MainCategory",
                table: "Products Table",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products Futures Table",
                table: "Products Futures Table",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 1,
                column: "MainCategory",
                value: "Elektronik");

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 2,
                column: "MainCategory",
                value: "Elektronik");

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 3,
                column: "MainCategory",
                value: "Elektronik");

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 4,
                column: "MainCategory",
                value: "Elektronik");

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MainCategory", "Name" },
                values: new object[] { "Elektronik", "LENOVA BILGISAYAR" });

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MainCategory", "Name" },
                values: new object[] { "Elektronik", "HUAWEİ BILGISAYAR" });

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "MainCategory", "Name" },
                values: new object[] { "Elektronik", "APPLE BILGISAYAR" });

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "MainCategory", "Name" },
                values: new object[] { "Elektronik", "ASUS BILGISAYAR" });

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 9,
                column: "MainCategory",
                value: "Elektronik");

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "MainCategory" },
                values: new object[] { 3, "Elektronik" });

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "MainCategory" },
                values: new object[] { 3, "Elektronik" });

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "MainCategory" },
                values: new object[] { 3, "Elektronik" });

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "MainCategory" },
                values: new object[] { 4, "Elektronik" });

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "MainCategory" },
                values: new object[] { 4, "Elektronik" });

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "MainCategory" },
                values: new object[] { 4, "Elektronik" });

            migrationBuilder.UpdateData(
                table: "Products Table",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "MainCategory" },
                values: new object[] { 4, "Elektronik" });

            migrationBuilder.AddForeignKey(
                name: "FK_Products Futures Table_Products Table_ProductId",
                table: "Products Futures Table",
                column: "ProductId",
                principalTable: "Products Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products Table_Categories Table_CategoryId",
                table: "Products Table",
                column: "CategoryId",
                principalTable: "Categories Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
