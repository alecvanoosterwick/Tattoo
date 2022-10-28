using Microsoft.EntityFrameworkCore.Migrations;

namespace Tattoo_Shop.Migrations
{
    public partial class Migration9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Tattoo");

            migrationBuilder.RenameTable(
                name: "TattooKlant",
                newName: "TattooKlant",
                newSchema: "Tattoo");

            migrationBuilder.RenameTable(
                name: "Tattoo",
                newName: "Tattoo",
                newSchema: "Tattoo");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Product",
                newSchema: "Tattoo");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Orders",
                newSchema: "Tattoo");

            migrationBuilder.RenameTable(
                name: "OrderLijn",
                newName: "OrderLijn",
                newSchema: "Tattoo");

            migrationBuilder.RenameTable(
                name: "Artist",
                newName: "Artist",
                newSchema: "Tattoo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "TattooKlant",
                schema: "Tattoo",
                newName: "TattooKlant");

            migrationBuilder.RenameTable(
                name: "Tattoo",
                schema: "Tattoo",
                newName: "Tattoo");

            migrationBuilder.RenameTable(
                name: "Product",
                schema: "Tattoo",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Orders",
                schema: "Tattoo",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "OrderLijn",
                schema: "Tattoo",
                newName: "OrderLijn");

            migrationBuilder.RenameTable(
                name: "Artist",
                schema: "Tattoo",
                newName: "Artist");
        }
    }
}
