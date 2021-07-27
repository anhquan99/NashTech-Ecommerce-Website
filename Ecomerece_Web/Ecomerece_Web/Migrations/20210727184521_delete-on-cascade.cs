using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecomerece_Web.Migrations
{
    public partial class deleteoncascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_images_products_productNameID",
                table: "images");

            migrationBuilder.DropForeignKey(
                name: "FK_products_brands_brandNameID",
                table: "products");

            migrationBuilder.AddForeignKey(
                name: "FK_images_products_productNameID",
                table: "images",
                column: "productNameID",
                principalTable: "products",
                principalColumn: "productNameID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_brands_brandNameID",
                table: "products",
                column: "brandNameID",
                principalTable: "brands",
                principalColumn: "brandNameID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_images_products_productNameID",
                table: "images");

            migrationBuilder.DropForeignKey(
                name: "FK_products_brands_brandNameID",
                table: "products");

            migrationBuilder.AddForeignKey(
                name: "FK_images_products_productNameID",
                table: "images",
                column: "productNameID",
                principalTable: "products",
                principalColumn: "productNameID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_brands_brandNameID",
                table: "products",
                column: "brandNameID",
                principalTable: "brands",
                principalColumn: "brandNameID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
