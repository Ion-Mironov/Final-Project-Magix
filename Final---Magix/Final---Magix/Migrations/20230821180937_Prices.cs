using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final___Magix.Migrations
{
    /// <inheritdoc />
    public partial class Prices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_StoreInventoryPrice_StoreInventory_Id",
                table: "StoreInventoryPrice",
                column: "Id",
                principalTable: "StoreInventory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreInventoryPrice_StoreInventory_Id",
                table: "StoreInventoryPrice");
        }
    }
}
