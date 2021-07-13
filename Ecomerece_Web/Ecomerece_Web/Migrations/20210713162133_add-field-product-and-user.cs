using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecomerece_Web.Migrations
{
    public partial class addfieldproductanduser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ProductUser",
                columns: table => new
                {
                    userWantProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    wantedProductproductNameID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUser", x => new { x.userWantProductId, x.wantedProductproductNameID });
                    table.ForeignKey(
                        name: "FK_ProductUser_AspNetUsers_userWantProductId",
                        column: x => x.userWantProductId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductUser_products_wantedProductproductNameID",
                        column: x => x.wantedProductproductNameID,
                        principalTable: "products",
                        principalColumn: "productNameID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductUser_wantedProductproductNameID",
                table: "ProductUser",
                column: "wantedProductproductNameID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductUser");

            migrationBuilder.DropColumn(
                name: "address",
                table: "AspNetUsers");
        }
    }
}
