using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecomerece_Web.Migrations
{
    public partial class addfieldproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "usedPrice",
                table: "products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "usedPrice",
                table: "products");
        }
    }
}
