using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingApp.Data.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPreferredDrink",
                table: "Products",
                newName: "IsPreferredProduct");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPreferredProduct",
                table: "Products",
                newName: "IsPreferredDrink");
        }
    }
}
