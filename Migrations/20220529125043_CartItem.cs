using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaptopStore.Migrations
{
    public partial class CartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");
        }
    }
}
