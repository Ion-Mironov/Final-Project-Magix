using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final___Magix.Migrations
{
    /// <inheritdoc />
    public partial class Magic1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StoreInventory",
                columns: new[] { "Id", "ImageBorderCrop", "ImageLarge", "ImageNormal", "ImageSmall", "Name", "PriceId", "Quantity" },
                values: new object[] { "655c489f-bffb-45a4-8e7c-2d1a352201788", "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "Smash to Smithereens", null, 11 });

            migrationBuilder.InsertData(
                table: "StoreInventoryPrice",
                columns: new[] { "Id", "Usd" },
                values: new object[] { "655c489f-bffb-45a4-8e7c-2d1a352201788", 0.25m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StoreInventory",
                keyColumn: "Id",
                keyValue: "655c489f-bffb-45a4-8e7c-2d1a352201788");

            migrationBuilder.DeleteData(
                table: "StoreInventoryPrice",
                keyColumn: "Id",
                keyValue: "655c489f-bffb-45a4-8e7c-2d1a352201788");
        }
    }
}
