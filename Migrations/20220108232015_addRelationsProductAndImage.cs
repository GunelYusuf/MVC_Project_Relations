using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Projects.Migrations
{
    public partial class addRelationsProductAndImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShopProductId",
                table: "images",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
