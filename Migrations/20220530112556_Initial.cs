using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaptopStore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Laptop",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shortDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    longDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<int>(type: "int", nullable: false),
                    imgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isFavorite = table.Column<bool>(type: "bit", nullable: false),
                    isAvailable = table.Column<bool>(type: "bit", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptop", x => x.id);
                    table.ForeignKey(
                        name: "FK_Laptop_Category_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    laptopid = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_CartItem_Laptop_laptopid",
                        column: x => x.laptopid,
                        principalTable: "Laptop",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_laptopid",
                table: "CartItem",
                column: "laptopid");

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_categoryId",
                table: "Laptop",
                column: "categoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Laptop");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
