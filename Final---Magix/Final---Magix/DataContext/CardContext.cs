using Final___Magix.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Security.Cryptography.Xml;

namespace Final___Magix.DataContext
{
    public class CardContext : DbContext
    {
        private const string CONNECTION_STRING = "Server=(localdb)\\mssqllocaldb;Database=Final---Magix;Trusted_Connection=True;MultipleActiveResultSets=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING, builder =>
            {
                builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            });
            base.OnConfiguring(optionsBuilder);
        }
        //Seed the data into BulkData table (done this way due to issues)
        //public CardContext(DbContextOptions<CardContext> options) : base(options) 
        //{
        //    SeedData();
        //}
        public DbSet<CardModel> Cards { get; set; } //represents the card collection
        public DbSet<TradeInModel> TradeIns { get; set; } //Historical trade-ins database
        public DbSet<Inventory> StoreInventory { get; set; } //Store Inventory atabase
        public DbSet<BulkData> BulkData { get; set; } //BulkDataModel.BulkData database (Id, Name, ImageId, PriceId)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			//// Seed initial store inventory data
			///
			modelBuilder.Entity<Inventory>().HasData(
                new Inventory
                { 
                    Id = "655c489f-bffb-45a4-8e7c-2d1a35220197",
                    Name = "Smash to Smithereens",
                    ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    Quantity = 10,
                    Price = (decimal)4.99M
                },
                new Inventory
                {
                    Id = "655c489f-bffb-45a4-8e7c-2d1a35220196",
                    Name = "Smash to Smithereens",
                    ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    Quantity = 10,
                    Price = (decimal)4.99M
                },
                new Inventory
                {
                    Id = "655c489f-bffb-45a4-8e7c-2d1a35220195",
                    Name = "Smash to Smithereens",
                    ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    Quantity = 10,
					Price = (decimal)4.99M
				},
                new Inventory
                {
                    Id = "655c489f-bffb-45a4-8e7c-2d1a35220194",
                    Name = "Smash to Smithereens",
                    ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    Quantity = 10,
					Price = (decimal)4.99M
				},
                new Inventory
                {
                    Id = "655c489f-bffb-45a4-8e7c-2d1a35220193",
                    Name = "Smash to Smithereens",
                    ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    Quantity = 10,
					Price = (decimal)4.99M
				},
                new Inventory
                {
                    Id = "655c489f-bffb-45a4-8e7c-2d1a35220192",
                    Name = "Smash to Smithereens",
                    ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    Quantity = 10,
					Price = (decimal)4.99M
				},
                new Inventory
                {
                    Id = "655c489f-bffb-45a4-8e7c-2d1a35220191",
                    Name = "Smash to Smithereens",
                    ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    Quantity = 10,
					Price = (decimal)4.99M
				},
                new Inventory
                {
                    Id = "655c489f-bffb-45a4-8e7c-2d1a35220190",
                    Name = "Smash to Smithereens",
                    ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                    Quantity = 10,
					Price = (decimal)4.99M
				},

				 new Inventory
				 {
					 Id = "655c489f-bffb-45a4-8e7c-2d1a352201788",
					 Name = "Smash to Smithereens",
					 ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
					 ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
					 ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
					 ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
					 Quantity = 11,
					 Price = (decimal)4.99M
				 });
        }

        public void SeedData()
        {
            //Check if the database have already been seeded
            if (BulkData.Any())
            {   //If the database has been seeded, exit this method
                return;
            }
            //If the database has not been seeded, seed the databases.
            var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "infos", "AllCards.json");
            //Read the file into a var
            var jsonText = File.ReadAllText(jsonPath);
            //Deserialize the var into List<BulkDataModel>
            var cardList = JsonConvert.DeserializeObject<List<BulkData>>(jsonText);

            foreach (var cardData in cardList)
            {
                var card = new BulkData()
                {
                    Id = cardData.Id,
                    Name = cardData.Name,
                    ImageSmall = cardData.ImageSmall,
                    ImageNormal = cardData.ImageNormal,
                    ImageLarge = cardData.ImageLarge,
                    ImageBorderCrop = cardData.ImageBorderCrop,
                    Price = cardData.Price
                };
                BulkData.Add(card);
            }
            SaveChanges();
        }
    }
}
