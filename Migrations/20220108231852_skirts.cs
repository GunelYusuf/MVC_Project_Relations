using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Projects.Migrations
{
    public partial class skirts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "images");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "images",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
