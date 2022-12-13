using Microsoft.EntityFrameworkCore.Migrations;

namespace Tattoo_Shop.Migrations
{
    public partial class crud : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLijn_Orders_OrderId",
                schema: "Tattoo",
                table: "OrderLijn");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLijn_Product_ProductId",
                schema: "Tattoo",
                table: "OrderLijn");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_CustomUserId",
                schema: "Tattoo",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                schema: "Tattoo",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderLijn",
                schema: "Tattoo",
                table: "OrderLijn");

            migrationBuilder.RenameTable(
                name: "Orders",
                schema: "Tattoo",
                newName: "Order",
                newSchema: "Tattoo");

            migrationBuilder.RenameTable(
                name: "OrderLijn",
                schema: "Tattoo",
                newName: "Orderlijns",
                newSchema: "Tattoo");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomUserId",
                schema: "Tattoo",
                table: "Order",
                newName: "IX_Order_CustomUserId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLijn_ProductId",
                schema: "Tattoo",
                table: "Orderlijns",
                newName: "IX_Orderlijns_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLijn_OrderId",
                schema: "Tattoo",
                table: "Orderlijns",
                newName: "IX_Orderlijns_OrderId");

            migrationBuilder.AddColumn<decimal>(
                name: "Prijs",
                schema: "Tattoo",
                table: "Order",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Product",
                schema: "Tattoo",
                table: "Order",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                schema: "Tattoo",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orderlijns",
                schema: "Tattoo",
                table: "Orderlijns",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_CustomUserId",
                schema: "Tattoo",
                table: "Order",
                column: "CustomUserId",
                principalSchema: "Tattoo",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderlijns_Order_OrderId",
                schema: "Tattoo",
                table: "Orderlijns",
                column: "OrderId",
                principalSchema: "Tattoo",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderlijns_Product_ProductId",
                schema: "Tattoo",
                table: "Orderlijns",
                column: "ProductId",
                principalSchema: "Tattoo",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_CustomUserId",
                schema: "Tattoo",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderlijns_Order_OrderId",
                schema: "Tattoo",
                table: "Orderlijns");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderlijns_Product_ProductId",
                schema: "Tattoo",
                table: "Orderlijns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orderlijns",
                schema: "Tattoo",
                table: "Orderlijns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                schema: "Tattoo",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Prijs",
                schema: "Tattoo",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Product",
                schema: "Tattoo",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "Orderlijns",
                schema: "Tattoo",
                newName: "OrderLijn",
                newSchema: "Tattoo");

            migrationBuilder.RenameTable(
                name: "Order",
                schema: "Tattoo",
                newName: "Orders",
                newSchema: "Tattoo");

            migrationBuilder.RenameIndex(
                name: "IX_Orderlijns_ProductId",
                schema: "Tattoo",
                table: "OrderLijn",
                newName: "IX_OrderLijn_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Orderlijns_OrderId",
                schema: "Tattoo",
                table: "OrderLijn",
                newName: "IX_OrderLijn_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CustomUserId",
                schema: "Tattoo",
                table: "Orders",
                newName: "IX_Orders_CustomUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderLijn",
                schema: "Tattoo",
                table: "OrderLijn",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                schema: "Tattoo",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLijn_Orders_OrderId",
                schema: "Tattoo",
                table: "OrderLijn",
                column: "OrderId",
                principalSchema: "Tattoo",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLijn_Product_ProductId",
                schema: "Tattoo",
                table: "OrderLijn",
                column: "ProductId",
                principalSchema: "Tattoo",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_CustomUserId",
                schema: "Tattoo",
                table: "Orders",
                column: "CustomUserId",
                principalSchema: "Tattoo",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
