using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final___Magix.Migrations
{
    /// <inheritdoc />
    public partial class InitSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BulkData",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageSmall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageNormal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageLarge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageBorderCrop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BulkData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreInventory",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageSmall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageNormal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageLarge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageBorderCrop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreInventory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TradeIns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeIns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Set = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Print = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foil = table.Column<bool>(type: "bit", nullable: false),
                    TradeInModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_TradeIns_TradeInModelId",
                        column: x => x.TradeInModelId,
                        principalTable: "TradeIns",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "StoreInventory",
                columns: new[] { "Id", "ImageBorderCrop", "ImageLarge", "ImageNormal", "ImageSmall", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { "655c489f-bffb-45a4-8e7c-2d1a352201788", "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "Smash to Smithereens", 4.99m, 11 },
                    { "655c489f-bffb-45a4-8e7c-2d1a35220190", "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "Smash to Smithereens", 4.99m, 10 },
                    { "655c489f-bffb-45a4-8e7c-2d1a35220191", "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "Smash to Smithereens", 4.99m, 10 },
                    { "655c489f-bffb-45a4-8e7c-2d1a35220192", "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "Smash to Smithereens", 4.99m, 10 },
                    { "655c489f-bffb-45a4-8e7c-2d1a35220193", "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "Smash to Smithereens", 4.99m, 10 },
                    { "655c489f-bffb-45a4-8e7c-2d1a35220194", "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "Smash to Smithereens", 4.99m, 10 },
                    { "655c489f-bffb-45a4-8e7c-2d1a35220195", "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "Smash to Smithereens", 4.99m, 10 },
                    { "655c489f-bffb-45a4-8e7c-2d1a35220196", "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "Smash to Smithereens", 4.99m, 10 },
                    { "655c489f-bffb-45a4-8e7c-2d1a35220197", "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "Smash to Smithereens", 4.99m, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_TradeInModelId",
                table: "Cards",
                column: "TradeInModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BulkData");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "StoreInventory");

            migrationBuilder.DropTable(
                name: "TradeIns");
        }
    }
}
