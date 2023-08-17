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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BulkData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreInventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
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
                table: "BulkData",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "0050dd40-9a18-41e4-97e6-fce5bf220ccf", "Security Rhox" },
                    { "01f842c8-cd6c-4f4d-9aa8-417a92b37867", "Echoing Ruin" },
                    { "033afbd5-9937-4957-98ba-48e469a490bb", "Miscast" },
                    { "052b743a-456d-49c3-881e-4f30c7645fa5", "Puppet's Verdict" },
                    { "065e30fe-03e5-4558-8f41-42992b07712e", "Cherubael" },
                    { "070ff479-9d87-4ab6-aaaa-e96b9df0bac4", "Spinning Wheel" },
                    { "076e7c58-a6fe-4882-8f8d-698be9a7f22d", "Mental Vapors" },
                    { "08aea6e3-c8a8-4964-b95d-4c639da55de1", "Niblis of the Mist" },
                    { "0daf6a74-57f7-4c44-9413-a28002f3de4c", "Slime Molding" },
                    { "0db18acd-36dd-4469-a370-430141858722", "Gyox, Brutal Carnivora" },
                    { "0e0fa5ab-c4d1-4b2d-ad62-feb651e4b11c", "Thraben Doomsayer" },
                    { "0e1263ea-adc9-442b-b13e-9afb69596372", "Hostile Minotaur" },
                    { "0e893613-423e-409b-9334-292bd252405b", "You Come to the Gnoll Camp" },
                    { "11e78f75-bf58-4c61-9654-c5d355b5e526", "Plow Through Reito" },
                    { "12220d53-3356-4541-aa43-a0de6ed3f7d0", "Barren Glory" },
                    { "14aa4474-96a0-4c1d-a09d-73b9c1073b00", "Scrapheap" },
                    { "14e8195a-d0e4-4b11-b413-765ed1cae834", "Delaying Shield" },
                    { "1640b76d-15d6-4b08-a34b-c5432259d570", "Aether Adept" },
                    { "1fe7a4f0-d677-4ae2-883c-eb46d0999584", "Messenger Jays" },
                    { "248d71f9-89ef-492e-a854-a890f7d91ef8", "Spellbinding Soprano" },
                    { "25283518-cabb-4fa6-ab92-c989190ec9f3", "Stormcloud Djinn" },
                    { "2637f860-01dd-4559-97b3-71c2e7cdbca4", "Night Market Aeronaut" },
                    { "29214308-711a-490f-8e93-bf61baf1749c", "Karona's Zealot" },
                    { "2a1e7796-fbfb-4976-879f-bb748429d5c7", "Brine Hag" },
                    { "2ab08d69-210b-4b06-88a2-45281a1a4e1e", "Stinkweed Imp" },
                    { "335867c0-375d-4914-b9ff-032c59079775", "Order of the White Shield" },
                    { "358c18b7-5321-4793-b54a-e48e39548b9c", "Failed Conversion" },
                    { "364ed745-0dff-477a-a2c5-987639936337", "Forked Bolt" },
                    { "36a348bb-cdc5-4e2a-933f-21f91faab891", "Audacious Infiltrator" },
                    { "374b5d57-fd20-4062-9ec2-24ac557d9dde", "Mina and Denn, Wildborn" },
                    { "3ae69722-9cb9-4fb7-830f-a284d4a72027", "Brazen Upstart" },
                    { "3b045121-7742-41ee-be27-591692f42331", "Necromancer's Magemark" },
                    { "3ca0d060-7bf7-4311-92f4-6cdfef6f85df", "Ritual of Subdual" },
                    { "3cda5434-c0a5-4551-8e30-b1923f0001b8", "Kuldotha Ringleader" },
                    { "409bbc0f-dd40-4de5-931b-a1eb2939dc8c", "Wrenn and Six // Wrenn and Six" },
                    { "42cbad81-152a-435f-9289-f4b6483a059b", "Cradle of Safety" },
                    { "4501c6a1-37b8-4009-9c9b-69f0661ca730", "Lukamina, Wolf Form" },
                    { "4df70b14-5d67-4a92-aaba-72480c621d10", "Bolt of Keranos" },
                    { "4ff97c69-6a6b-401c-b0a1-55fa81045d19", "Braids, Arisen Nightmare" },
                    { "52118ff1-ad76-4b97-9fdc-6adfe80140f8", "Branchsnap Lorian" },
                    { "53cc3197-7a69-4b96-a701-aa3c54543958", "Ogre Painbringer" },
                    { "5480ac0a-883a-4f73-8e7c-56d64be410a3", "Nine-Fingers Keene" },
                    { "54ec2cd6-51f6-4e12-af90-fa254f14ad32", "Hornet" },
                    { "5526ff6e-c079-4ad4-ac8d-5e26ecacf50d", "Death's Shadow" },
                    { "55b6b7f0-d7fc-46b6-99ff-ba8206ecd628", "Ulamog's Despoiler" },
                    { "5dee47ab-d603-4346-97f4-a25dc3f47765", "Ancestral Anger" },
                    { "643891b6-23d0-4734-81e0-b315d2d58f50", "Tel-Jilad Fallen" },
                    { "655c489f-bffb-45a4-8e7c-2d1a35220197", "Smash to Smithereens" },
                    { "6b34af88-bc4e-4ca8-8662-7dc4050c62c5", "Fists of Flame" },
                    { "71a482cf-a1cd-47b5-a76a-08e03965c679", "Dizzying Gaze" },
                    { "72204934-f5aa-4559-8f7e-7b0b223580d0", "Spellskite" },
                    { "726fe2e7-bd1b-4c11-a098-6c8abfbdf06e", "City of Ass" },
                    { "7520ee10-3ed1-40eb-86a0-3e463a5fba76", "Glint Raker" },
                    { "77ceba8b-de19-4db8-b5a7-f5df49bf241f", "Old Gnawbone" },
                    { "785e1a67-af94-48e8-bb37-4999d1fb4c66", "Phyrexian Bloodstock" },
                    { "7a9d23d5-2f94-48e6-824f-f1de8f742989", "Ulvenwald Observer" },
                    { "7bd0e025-7a75-4641-a51a-27df9dcde05f", "Crawling Barrens" },
                    { "7cc6972a-5305-423f-a936-16ee0fbf9200", "Cruel Deceiver" },
                    { "7e599847-8ab0-4fd6-b2c0-cb44a7669aa5", "The Locust God" },
                    { "7fcfe11a-fcc9-41e1-91ef-755bb4e22389", "Ghastly Demise" },
                    { "829069cf-7e63-4443-b679-65ad15d6ca5e", "Mythic Proportions" },
                    { "88e35c80-6cfe-49fc-8138-562233ccf987", "Erebos's Intervention" },
                    { "8a07b3b2-0354-4026-9c7d-24ce06048271", "Hermit Druid Avatar" },
                    { "8f5228dc-ec9d-456f-a89c-1bc592a1bbab", "Ettercap // Web Shot" },
                    { "98956e73-04e4-4d7f-bda5-cfa78eb71350", "Anointer Priest" },
                    { "99ad5807-2adc-40d7-b398-d03fd2cd58b9", "Conclave Sledge-Captain" },
                    { "9af69b5e-f713-4af6-9990-f99be7801f73", "Curse of the Forsaken" },
                    { "9c258aa1-cd9f-45e9-b478-d689b78850cd", "Eye of Yawgmoth" },
                    { "9cb19ac2-edf9-4f9a-b9ba-2a33ba96a4d8", "Piracy Charm" },
                    { "9d15f7b5-5070-4742-a05c-623822d874fb", "Sivvi's Valor" },
                    { "9ff08225-82a5-4636-be6a-d38d32f5663f", "Blood Pet" },
                    { "a06eea30-810b-4623-9862-ec71c4bed11a", "Giant Warrior" },
                    { "a17f4b21-6478-407d-b567-2888349f3b66", "Horizon Seeker" },
                    { "a20f5392-5cde-4326-a322-7463ec4b0515", "Silverfur Partisan" },
                    { "a46e8f6a-3a1a-4c30-9348-4b31882267eb", "Rack and Ruin" },
                    { "a8ec9be6-c8ad-4a82-8253-c49cdb9443ba", "Dramatic Finale" },
                    { "abe8eefe-c9f8-43f7-a348-8afee8b0ec68", "Ability Punchcard" },
                    { "ad34094d-a7ec-4b04-a288-4d4f1a07fc6b", "Backfire" },
                    { "ad925fb0-1d5c-44a0-8347-202a38c23107", "Iron Maiden" },
                    { "adffef78-f776-42d3-ab40-3347c8e5c88b", "Totally Lost" },
                    { "af443b8c-203f-46f0-9233-60f962e5baa6", "Pygmy Giant" },
                    { "afe165cd-8ef7-408e-ae56-3c6a0cc4e409", "Fugitive Druid" },
                    { "b0244a1f-e696-4223-9c14-22c2ca3cb738", "Herd Migration" },
                    { "b3e75332-4f26-42c9-818f-f8f9396b4210", "Ring of Gix" },
                    { "b9a41cfc-f329-4e69-a785-835f69c7d2ba", "Cartographer's Survey" },
                    { "bbf9a803-473a-4c38-b352-d47c4fd93d5e", "Reach of Shadows" },
                    { "bf42524c-97e5-40b2-8a6d-d2a1f0a9eb65", "Keldon Marauders" },
                    { "c2ce54a3-f3eb-48a0-bfa2-5f4b90e413f0", "Dusk Charger" },
                    { "c505f1be-4d9f-4536-a3f7-c6e6e19d5678", "Optical Optimizer" },
                    { "c6667e4f-f0f6-4416-940a-d03bed75f5a7", "Clown Car" },
                    { "c75b81b5-5c84-45d4-832a-20c038372bc6", "Wasp" },
                    { "c777432f-7965-4ad8-8d53-93919ae767d4", "Primal Whisperer" },
                    { "c7978371-9ea8-4264-9a2f-38226ea25018", "Obsidian Battle-Axe" },
                    { "c7d4c858-5a11-485d-a514-12a6d80459f0", "Body Snatcher" },
                    { "c9d9378d-e553-48b5-8a23-59a35329eda2", "Daring Thief" },
                    { "cb720ffe-0836-485d-acef-49ce3c48d947", "Half-Elf Monk // Half-Elf Monk" },
                    { "cc61a398-cf16-415b-b3cf-897217dc7cc9", "Sonic Assault" },
                    { "d117ed81-7b5c-4e29-b958-6126d48ac5a6", "Magus of the Bazaar" },
                    { "d21e0516-4430-4292-850b-f5c524d7f8f8", "Shield Mare" },
                    { "d651b9e9-d723-4340-a010-d71b2a697e73", "Serpentine Curve" },
                    { "da55c6a1-1f26-4254-ac62-fdbe94278de5", "Diviner's Lockbox" },
                    { "dafb963c-18a5-4770-afb9-0121c614de40", "Kiri-Onna" },
                    { "db0489ee-96b6-4437-a716-ee07ecbd4cb7", "Knighted Myr" },
                    { "db9103c9-084f-4ad2-8b7b-ca52be97619d", "Skyclave Geopede" },
                    { "e09e9b65-ff0e-4efe-b96a-ede69c96e2ea", "Carth the Lion" },
                    { "e0efe5b1-c515-4642-aca2-3eba68fe63ff", "Dhund Operative" },
                    { "e43d959f-6055-4578-a69a-0ec93e993e21", "Armored Wolf-Rider" },
                    { "e4810919-b379-40db-a68b-a769dd3ee32d", "Shockmaw Dragon" },
                    { "e51b48e9-a75a-4acd-9462-5e1ac2b0d803", "Slagwoods Bridge" },
                    { "e55ca835-b7f3-497c-b0bc-50a182cabecf", "Myr Galvanizer" },
                    { "e6246cf3-76bd-476b-9cd9-789b6ad48887", "Kheru Mind-Eater" },
                    { "e72a911e-8291-48ca-bfc6-8907e3b57011", "Open the Way" },
                    { "e7fb8520-1bc4-40e7-a4cc-2933ed7e0c00", "Mazirek, Kraul Death Priest" },
                    { "e9d3500e-09ba-48b6-933f-25b4625b79aa", "Elegant Entourage" },
                    { "ed4cc273-adc3-4f46-9743-134b552d1d56", "Balthor the Defiled" },
                    { "f012f5c8-a974-40a4-9375-071e4d95182a", "Azorius Signet" },
                    { "f110698e-a343-4eff-ba23-ed7ac5a3f87b", "Akki War Paint" },
                    { "f200ea9a-198b-4ba2-ad2b-ea4a133b7f40", "Necrogoyf" },
                    { "f4072640-0f9b-4f0a-84cc-eda415cc92e7", "Avenging Hunter" },
                    { "f47e5303-c07a-4be0-a314-bf5739a856e5", "Thirsting Axe" },
                    { "f928e8e8-aa20-402c-85bd-59106e9b9cc7", "Leave // Chance" }
                });

            migrationBuilder.InsertData(
                table: "StoreInventory",
                columns: new[] { "Id", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "url", "Card A", 5.99m, 0 },
                    { 2, "url", "Card B", 3.49m, 0 }
                });

            migrationBuilder.InsertData(
                table: "TradeIns",
                column: "Id",
                values: new object[]
                {
                    1,
                    2
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
