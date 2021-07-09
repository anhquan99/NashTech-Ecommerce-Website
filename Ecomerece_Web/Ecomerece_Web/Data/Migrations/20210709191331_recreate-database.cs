using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecomerece_Web.Data.Migrations
{
    public partial class recreatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "fullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    brandNameID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.brandNameID);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    categoryNameID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.categoryNameID);
                });

            migrationBuilder.CreateTable(
                name: "colors",
                columns: table => new
                {
                    colorNameID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colors", x => x.colorNameID);
                });

            migrationBuilder.CreateTable(
                name: "silhouettes",
                columns: table => new
                {
                    silhouetteNameID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_silhouettes", x => x.silhouetteNameID);
                });

            migrationBuilder.CreateTable(
                name: "types",
                columns: table => new
                {
                    typeNameID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_types", x => x.typeNameID);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productNameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    releaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    upperMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    colorWay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    story = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false),
                    wallpaper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brandNameID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    colorNameID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    categoryNameID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    typeNameID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    silhouetteNameID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.productNameID);
                    table.ForeignKey(
                        name: "FK_products_brands_brandNameID",
                        column: x => x.brandNameID,
                        principalTable: "brands",
                        principalColumn: "brandNameID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_categories_categoryNameID",
                        column: x => x.categoryNameID,
                        principalTable: "categories",
                        principalColumn: "categoryNameID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_colors_colorNameID",
                        column: x => x.colorNameID,
                        principalTable: "colors",
                        principalColumn: "colorNameID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_silhouettes_silhouetteNameID",
                        column: x => x.silhouetteNameID,
                        principalTable: "silhouettes",
                        principalColumn: "silhouetteNameID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_types_typeNameID",
                        column: x => x.typeNameID,
                        principalTable: "types",
                        principalColumn: "typeNameID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "images",
                columns: table => new
                {
                    imageNameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    productNameID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_images", x => x.imageNameID);
                    table.ForeignKey(
                        name: "FK_images_products_productNameID",
                        column: x => x.productNameID,
                        principalTable: "products",
                        principalColumn: "productNameID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_images_productNameID",
                table: "images",
                column: "productNameID");

            migrationBuilder.CreateIndex(
                name: "IX_products_brandNameID",
                table: "products",
                column: "brandNameID");

            migrationBuilder.CreateIndex(
                name: "IX_products_categoryNameID",
                table: "products",
                column: "categoryNameID");

            migrationBuilder.CreateIndex(
                name: "IX_products_colorNameID",
                table: "products",
                column: "colorNameID");

            migrationBuilder.CreateIndex(
                name: "IX_products_silhouetteNameID",
                table: "products",
                column: "silhouetteNameID");

            migrationBuilder.CreateIndex(
                name: "IX_products_typeNameID",
                table: "products",
                column: "typeNameID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "images");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "colors");

            migrationBuilder.DropTable(
                name: "silhouettes");

            migrationBuilder.DropTable(
                name: "types");

            migrationBuilder.DropColumn(
                name: "fullName",
                table: "AspNetUsers");
        }
    }
}
