using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecomerece_Web.Data.Migrations
{
    public partial class updateproductfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "rating",
                table: "products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "view",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rating",
                table: "products");

            migrationBuilder.DropColumn(
                name: "view",
                table: "products");
        }
    }
}
