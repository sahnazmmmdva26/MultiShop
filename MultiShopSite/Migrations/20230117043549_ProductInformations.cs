using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MultiShopSite.Migrations
{
    /// <inheritdoc />
    public partial class ProductInformations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductInformation_ProductInformationId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInformation",
                table: "ProductInformation");

            migrationBuilder.RenameTable(
                name: "ProductInformation",
                newName: "ProductInformations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInformations",
                table: "ProductInformations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductInformations_ProductInformationId",
                table: "Products",
                column: "ProductInformationId",
                principalTable: "ProductInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductInformations_ProductInformationId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInformations",
                table: "ProductInformations");

            migrationBuilder.RenameTable(
                name: "ProductInformations",
                newName: "ProductInformation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInformation",
                table: "ProductInformation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductInformation_ProductInformationId",
                table: "Products",
                column: "ProductInformationId",
                principalTable: "ProductInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
