using Microsoft.EntityFrameworkCore.Migrations;

namespace VarkalaApp.Migrations
{
    public partial class UpdatedProductCategoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Active",
                table: "ProductCategories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "ProductCategories");
        }
    }
}
