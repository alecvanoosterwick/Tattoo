using Microsoft.EntityFrameworkCore.Migrations;

namespace Tattoo_Shop.Migrations
{
    public partial class Migration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TattooKlant_Tattoos_TattooId",
                table: "TattooKlant");

            migrationBuilder.DropForeignKey(
                name: "FK_Tattoos_Artist_ArtistId",
                table: "Tattoos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tattoos",
                table: "Tattoos");

            migrationBuilder.RenameTable(
                name: "Tattoos",
                newName: "Tattoo");

            migrationBuilder.RenameIndex(
                name: "IX_Tattoos_ArtistId",
                table: "Tattoo",
                newName: "IX_Tattoo_ArtistId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tattoo",
                table: "Tattoo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tattoo_Artist_ArtistId",
                table: "Tattoo",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TattooKlant_Tattoo_TattooId",
                table: "TattooKlant",
                column: "TattooId",
                principalTable: "Tattoo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tattoo_Artist_ArtistId",
                table: "Tattoo");

            migrationBuilder.DropForeignKey(
                name: "FK_TattooKlant_Tattoo_TattooId",
                table: "TattooKlant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tattoo",
                table: "Tattoo");

            migrationBuilder.RenameTable(
                name: "Tattoo",
                newName: "Tattoos");

            migrationBuilder.RenameIndex(
                name: "IX_Tattoo_ArtistId",
                table: "Tattoos",
                newName: "IX_Tattoos_ArtistId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tattoos",
                table: "Tattoos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TattooKlant_Tattoos_TattooId",
                table: "TattooKlant",
                column: "TattooId",
                principalTable: "Tattoos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tattoos_Artist_ArtistId",
                table: "Tattoos",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
