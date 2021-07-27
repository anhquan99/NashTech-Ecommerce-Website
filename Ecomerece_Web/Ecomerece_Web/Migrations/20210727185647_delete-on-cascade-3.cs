using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecomerece_Web.Migrations
{
    public partial class deleteoncascade3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_images_products_productNameID",
                table: "images");

            migrationBuilder.AddForeignKey(
                name: "FK_images_products_productNameID",
                table: "images",
                column: "productNameID",
                principalTable: "products",
                principalColumn: "productNameID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_images_products_productNameID",
                table: "images");

            migrationBuilder.AddForeignKey(
                name: "FK_images_products_productNameID",
                table: "images",
                column: "productNameID",
                principalTable: "products",
                principalColumn: "productNameID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
