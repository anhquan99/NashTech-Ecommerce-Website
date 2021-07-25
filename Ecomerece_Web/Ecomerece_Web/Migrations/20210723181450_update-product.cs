using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecomerece_Web.Migrations
{
    public partial class updateproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_brands_brandNameID",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_categoryNameID",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_colors_colorNameID",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_silhouettes_silhouetteNameID",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_types_typeNameID",
                table: "products");

            migrationBuilder.AlterColumn<string>(
                name: "typeNameID",
                table: "products",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "silhouetteNameID",
                table: "products",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "coverImg",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "colorNameID",
                table: "products",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "categoryNameID",
                table: "products",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "brandNameID",
                table: "products",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_products_brands_brandNameID",
                table: "products",
                column: "brandNameID",
                principalTable: "brands",
                principalColumn: "brandNameID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_categoryNameID",
                table: "products",
                column: "categoryNameID",
                principalTable: "categories",
                principalColumn: "categoryNameID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_colors_colorNameID",
                table: "products",
                column: "colorNameID",
                principalTable: "colors",
                principalColumn: "colorNameID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_silhouettes_silhouetteNameID",
                table: "products",
                column: "silhouetteNameID",
                principalTable: "silhouettes",
                principalColumn: "silhouetteNameID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_types_typeNameID",
                table: "products",
                column: "typeNameID",
                principalTable: "types",
                principalColumn: "typeNameID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_brands_brandNameID",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_categoryNameID",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_colors_colorNameID",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_silhouettes_silhouetteNameID",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_types_typeNameID",
                table: "products");

            migrationBuilder.AlterColumn<string>(
                name: "typeNameID",
                table: "products",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "silhouetteNameID",
                table: "products",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "coverImg",
                table: "products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "colorNameID",
                table: "products",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "categoryNameID",
                table: "products",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "brandNameID",
                table: "products",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_products_brands_brandNameID",
                table: "products",
                column: "brandNameID",
                principalTable: "brands",
                principalColumn: "brandNameID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_categoryNameID",
                table: "products",
                column: "categoryNameID",
                principalTable: "categories",
                principalColumn: "categoryNameID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_colors_colorNameID",
                table: "products",
                column: "colorNameID",
                principalTable: "colors",
                principalColumn: "colorNameID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_silhouettes_silhouetteNameID",
                table: "products",
                column: "silhouetteNameID",
                principalTable: "silhouettes",
                principalColumn: "silhouetteNameID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_types_typeNameID",
                table: "products",
                column: "typeNameID",
                principalTable: "types",
                principalColumn: "typeNameID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
