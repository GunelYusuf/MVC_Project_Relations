using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Projects.Migrations
{
    public partial class dresses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_images_shopProducts_ShopProductId",
                table: "images");

            migrationBuilder.DropIndex(
                name: "IX_images_ShopProductId",
                table: "images");

            migrationBuilder.DropColumn(
                name: "ShopProductId",
                table: "images");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShopProductId",
                table: "images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_images_ShopProductId",
                table: "images",
                column: "ShopProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_images_shopProducts_ShopProductId",
                table: "images",
                column: "ShopProductId",
                principalTable: "shopProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
