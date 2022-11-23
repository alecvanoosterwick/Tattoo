using Microsoft.EntityFrameworkCore.Migrations;

namespace Tattoo_Shop.Migrations
{
    public partial class CustomUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomUserId",
                schema: "Tattoo",
                table: "TattooKlant",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Naam",
                schema: "Tattoo",
                table: "Tattoo",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descriptie",
                schema: "Tattoo",
                table: "Tattoo",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Merk",
                schema: "Tattoo",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descriptie",
                schema: "Tattoo",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomUserId",
                schema: "Tattoo",
                table: "Orders",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Quantity",
                schema: "Tattoo",
                table: "OrderLijn",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AchterNaam",
                schema: "Tattoo",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Admin",
                schema: "Tattoo",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                schema: "Tattoo",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gemeente",
                schema: "Tattoo",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                schema: "Tattoo",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Postcode",
                schema: "Tattoo",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TelefoonNummer",
                schema: "Tattoo",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VoorNaam",
                schema: "Tattoo",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Wachtwoord",
                schema: "Tattoo",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Specialiteiten",
                schema: "Tattoo",
                table: "Artist",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TattooKlant_CustomUserId",
                schema: "Tattoo",
                table: "TattooKlant",
                column: "CustomUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomUserId",
                schema: "Tattoo",
                table: "Orders",
                column: "CustomUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_CustomUserId",
                schema: "Tattoo",
                table: "Orders",
                column: "CustomUserId",
                principalSchema: "Tattoo",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TattooKlant_AspNetUsers_CustomUserId",
                schema: "Tattoo",
                table: "TattooKlant",
                column: "CustomUserId",
                principalSchema: "Tattoo",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_CustomUserId",
                schema: "Tattoo",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_TattooKlant_AspNetUsers_CustomUserId",
                schema: "Tattoo",
                table: "TattooKlant");

            migrationBuilder.DropIndex(
                name: "IX_TattooKlant_CustomUserId",
                schema: "Tattoo",
                table: "TattooKlant");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomUserId",
                schema: "Tattoo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomUserId",
                schema: "Tattoo",
                table: "TattooKlant");

            migrationBuilder.DropColumn(
                name: "CustomUserId",
                schema: "Tattoo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AchterNaam",
                schema: "Tattoo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Admin",
                schema: "Tattoo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Adres",
                schema: "Tattoo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gemeente",
                schema: "Tattoo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Mail",
                schema: "Tattoo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Postcode",
                schema: "Tattoo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TelefoonNummer",
                schema: "Tattoo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VoorNaam",
                schema: "Tattoo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Wachtwoord",
                schema: "Tattoo",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Naam",
                schema: "Tattoo",
                table: "Tattoo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Descriptie",
                schema: "Tattoo",
                table: "Tattoo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Merk",
                schema: "Tattoo",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Descriptie",
                schema: "Tattoo",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Quantity",
                schema: "Tattoo",
                table: "OrderLijn",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Specialiteiten",
                schema: "Tattoo",
                table: "Artist",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
