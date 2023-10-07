using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories Table",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    MainCategory = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories Table", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products Table",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Stock = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(16,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    MainCategory = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products Table", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products Table_Categories Table_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products Futures Table",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products Futures Table", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products Futures Table_Products Table_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories Table",
                columns: new[] { "Id", "MainCategory", "Name" },
                values: new object[,]
                {
                    { 1, "Elektronik", "Beyaz Eşya" },
                    { 2, "Elektronik", "Bilgisayar" },
                    { 3, "Elektronik", "Küçük Ev Aletleri" },
                    { 4, "Elektronik", "Telefon" }
                });

            migrationBuilder.InsertData(
                table: "Products Table",
                columns: new[] { "Id", "CategoryId", "MainCategory", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 1, "Elektronik", "LG BUZDOLABI", 138999m, 100 },
                    { 2, 1, "Elektronik", "VESTEL BUZDOLABI", 16425m, 80 },
                    { 3, 1, "Elektronik", "SIEMENS BUZDOLABI", 37959m, 70 },
                    { 4, 1, "Elektronik", "SAMSUNG BUZDOLABI", 37989m, 50 },
                    { 5, 2, "Elektronik", "LENOVA BILGISAYAR", 13899m, 100 },
                    { 6, 2, "Elektronik", "HUAWEİ BILGISAYAR", 14425m, 80 },
                    { 7, 2, "Elektronik", "APPLE BILGISAYAR", 38959m, 70 },
                    { 8, 2, "Elektronik", "ASUS BILGISAYAR", 24000m, 50 },
                    { 9, 3, "Elektronik", "VESTEL KETTLE", 1400m, 100 },
                    { 10, 3, "Elektronik", "ARZUM BLENDER", 1000m, 80 },
                    { 11, 3, "Elektronik", "SINBO TARTI", 250m, 70 },
                    { 12, 3, "Elektronik", "KIWI AIRFRYER", 4500m, 50 },
                    { 13, 4, "Elektronik", "IPHONE 15", 55000m, 100 },
                    { 14, 4, "Elektronik", "IPHONE 14 ", 42000m, 80 },
                    { 15, 4, "Elektronik", "SAMSUNG S23", 28000m, 70 },
                    { 16, 4, "Elektronik", "SAMSUNG FE", 17000m, 50 }
                });

            migrationBuilder.InsertData(
                table: "Products Futures Table",
                columns: new[] { "Id", "Color", "Description", "ProductId" },
                values: new object[,]
                {
                    { 1, "Beyaz", "Insta View", 1 },
                    { 2, "Gri", "No Frost", 2 },
                    { 3, "Beyaz", "No Frost", 3 },
                    { 4, "Gri", "No Frost", 4 },
                    { 5, "Beyaz", "i5 8/512 Gb", 5 },
                    { 6, "Siyah", "Matebook D15", 6 },
                    { 7, "Beyaz", "Macbook Air 13", 7 },
                    { 8, "Gri", "Tuf Gaming", 8 },
                    { 9, "Beyaz", "1.5 L", 9 },
                    { 10, "Beyaz", "1700 Watt", 10 },
                    { 11, "Beyaz", "Dijital", 11 },
                    { 12, "Beyaz", "11 L", 12 },
                    { 13, "Beyaz", "512 GB", 13 },
                    { 14, "Siyah", "128 GB", 14 },
                    { 15, "Beyaz", "128 GB", 15 },
                    { 16, "Mavi", "128 GB", 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products Futures Table_ProductId",
                table: "Products Futures Table",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products Table_CategoryId",
                table: "Products Table",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products Futures Table");

            migrationBuilder.DropTable(
                name: "Products Table");

            migrationBuilder.DropTable(
                name: "Categories Table");
        }
    }
}
