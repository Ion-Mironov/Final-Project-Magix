using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final___Magix.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeedFinal : Migration
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
                    SetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Set = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foil = table.Column<bool>(type: "bit", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
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
                    { "033afbd5-9937-4957-98ba-48e469a490bb", "https://cards.scryfall.io/border_crop/front/0/3/033afbd5-9937-4957-98ba-48e469a490bb.jpg?1594735579", "https://cards.scryfall.io/large/front/0/3/033afbd5-9937-4957-98ba-48e469a490bb.jpg?1594735579", "https://cards.scryfall.io/normal/front/0/3/033afbd5-9937-4957-98ba-48e469a490bb.jpg?1594735579", "https://cards.scryfall.io/small/front/0/3/033afbd5-9937-4957-98ba-48e469a490bb.jpg?1594735579", "Miscast", 1.19m, 2 },
                    { "0e0fa5ab-c4d1-4b2d-ad62-feb651e4b11c", "https://cards.scryfall.io/border_crop/front/0/e/0e0fa5ab-c4d1-4b2d-ad62-feb651e4b11c.jpg?1591320182", "https://cards.scryfall.io/large/front/0/e/0e0fa5ab-c4d1-4b2d-ad62-feb651e4b11c.jpg?1591320182", "https://cards.scryfall.io/normal/front/0/e/0e0fa5ab-c4d1-4b2d-ad62-feb651e4b11c.jpg?1591320182", "https://cards.scryfall.io/small/front/0/e/0e0fa5ab-c4d1-4b2d-ad62-feb651e4b11c.jpg?1591320182", "Thraben Doomsayer", 0.19m, 10 },
                    { "374b5d57-fd20-4062-9ec2-24ac557d9dde", "https://cards.scryfall.io/border_crop/front/3/7/374b5d57-fd20-4062-9ec2-24ac557d9dde.jpg?1604195020", "https://cards.scryfall.io/large/front/3/7/374b5d57-fd20-4062-9ec2-24ac557d9dde.jpg?1604195020", "https://cards.scryfall.io/normal/front/3/7/374b5d57-fd20-4062-9ec2-24ac557d9dde.jpg?1604195020", "https://cards.scryfall.io/small/front/3/7/374b5d57-fd20-4062-9ec2-24ac557d9dde.jpg?1604195020", "Mina and Denn, Wildborn", 0.58m, 4 },
                    { "655c489f-bffb-45a4-8e7c-2d1a35220194", "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107", "Smash to Smithereens", 0.22m, 10 },
                    { "7bd0e025-7a75-4641-a51a-27df9dcde05f", "https://cards.scryfall.io/border_crop/front/7/b/7bd0e025-7a75-4641-a51a-27df9dcde05f.jpg?1604264359", "https://cards.scryfall.io/large/front/7/b/7bd0e025-7a75-4641-a51a-27df9dcde05f.jpg?1604264359", "https://cards.scryfall.io/normal/front/7/b/7bd0e025-7a75-4641-a51a-27df9dcde05f.jpg?1604264359", "https://cards.scryfall.io/small/front/7/b/7bd0e025-7a75-4641-a51a-27df9dcde05f.jpg?1604264359", "Crawling Barrens", 0.18m, 4 },
                    { "b0244a1f-e696-4223-9c14-22c2ca3cb738", "https://cards.scryfall.io/border_crop/front/b/0/b0244a1f-e696-4223-9c14-22c2ca3cb738.jpg?1673307696", "https://cards.scryfall.io/large/front/b/0/b0244a1f-e696-4223-9c14-22c2ca3cb738.jpg?1673307696", "https://cards.scryfall.io/normal/front/b/0/b0244a1f-e696-4223-9c14-22c2ca3cb738.jpg?1673307696", "https://cards.scryfall.io/small/front/b/0/b0244a1f-e696-4223-9c14-22c2ca3cb738.jpg?1673307696", "Herd Migration", 0.10m, 18 },
                    { "bf42524c-97e5-40b2-8a6d-d2a1f0a9eb65", "https://cards.scryfall.io/border_crop/front/b/f/bf42524c-97e5-40b2-8a6d-d2a1f0a9eb65.jpg?1618940501", "https://cards.scryfall.io/large/front/b/f/bf42524c-97e5-40b2-8a6d-d2a1f0a9eb65.jpg?1618940501", "https://cards.scryfall.io/normal/front/b/f/bf42524c-97e5-40b2-8a6d-d2a1f0a9eb65.jpg?1618940501", "https://cards.scryfall.io/small/front/b/f/bf42524c-97e5-40b2-8a6d-d2a1f0a9eb65.jpg?1618940501", "Keldon Marauders", 0.09m, 20 },
                    { "e6246cf3-76bd-476b-9cd9-789b6ad48887", "https://cards.scryfall.io/border_crop/front/e/6/e6246cf3-76bd-476b-9cd9-789b6ad48887.jpg?1562626991", "https://cards.scryfall.io/large/front/e/6/e6246cf3-76bd-476b-9cd9-789b6ad48887.jpg?1562626991", "https://cards.scryfall.io/normal/front/e/6/e6246cf3-76bd-476b-9cd9-789b6ad48887.jpg?1562626991", "https://cards.scryfall.io/small/front/e/6/e6246cf3-76bd-476b-9cd9-789b6ad48887.jpg?1562626991", "Kheru Mind-Eater", 0.91m, 2 },
                    { "ed4cc273-adc3-4f46-9743-134b552d1d56", "https://cards.scryfall.io/border_crop/front/e/d/ed4cc273-adc3-4f46-9743-134b552d1d56.jpg?1562632510", "https://cards.scryfall.io/large/front/e/d/ed4cc273-adc3-4f46-9743-134b552d1d56.jpg?1562632510", "https://cards.scryfall.io/normal/front/e/d/ed4cc273-adc3-4f46-9743-134b552d1d56.jpg?1562632510", "https://cards.scryfall.io/small/front/e/d/ed4cc273-adc3-4f46-9743-134b552d1d56.jpg?1562632510", "Balthor the Defiled", 11.89m, 2 }
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
