using Final___Magix.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

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

        public CardContext(DbContextOptions<CardContext> options) : base(options)
        {

        }

        public DbSet<CardModel> Cards { get; set; } // Represents the card collection
		public DbSet<TradeInModel> TradeIns { get; set; } // Historical trade-ins database
		public DbSet<Inventory> StoreInventory { get; set; } // Store Inventory database
		public DbSet<BulkData> BulkData { get; set; } // BulkData database (Id, Name, ImageId, PriceId)

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Seed initial store inventory data
			modelBuilder.Entity<Inventory>().HasData(
				new Inventory
				{
					Id = "ed4cc273-adc3-4f46-9743-134b552d1d56",
					Name = "Balthor the Defiled",
					ImageSmall = "https://cards.scryfall.io/small/front/e/d/ed4cc273-adc3-4f46-9743-134b552d1d56.jpg?1562632510",
					ImageNormal = "https://cards.scryfall.io/normal/front/e/d/ed4cc273-adc3-4f46-9743-134b552d1d56.jpg?1562632510",
					ImageLarge = "https://cards.scryfall.io/large/front/e/d/ed4cc273-adc3-4f46-9743-134b552d1d56.jpg?1562632510",
					ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/e/d/ed4cc273-adc3-4f46-9743-134b552d1d56.jpg?1562632510",
					Quantity = 2,
					Price = (decimal)11.89M
                },
				new Inventory
				{
					Id = "b0244a1f-e696-4223-9c14-22c2ca3cb738",
					Name = "Herd Migration",
					ImageSmall = "https://cards.scryfall.io/small/front/b/0/b0244a1f-e696-4223-9c14-22c2ca3cb738.jpg?1673307696",
					ImageNormal = "https://cards.scryfall.io/normal/front/b/0/b0244a1f-e696-4223-9c14-22c2ca3cb738.jpg?1673307696",
					ImageLarge = "https://cards.scryfall.io/large/front/b/0/b0244a1f-e696-4223-9c14-22c2ca3cb738.jpg?1673307696",
					ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/b/0/b0244a1f-e696-4223-9c14-22c2ca3cb738.jpg?1673307696",
					Quantity = 18,
					Price = (decimal)0.10M
				},
				new Inventory
				{
					Id = "7bd0e025-7a75-4641-a51a-27df9dcde05f",
					Name = "Crawling Barrens",
					ImageSmall = "https://cards.scryfall.io/small/front/7/b/7bd0e025-7a75-4641-a51a-27df9dcde05f.jpg?1604264359",
					ImageNormal = "https://cards.scryfall.io/normal/front/7/b/7bd0e025-7a75-4641-a51a-27df9dcde05f.jpg?1604264359",
					ImageLarge = "https://cards.scryfall.io/large/front/7/b/7bd0e025-7a75-4641-a51a-27df9dcde05f.jpg?1604264359",
					ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/7/b/7bd0e025-7a75-4641-a51a-27df9dcde05f.jpg?1604264359",
					Quantity = 4,
					Price = (decimal)0.18M
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
					Price = (decimal)0.22M
				},
				new Inventory
				{
					Id = "e6246cf3-76bd-476b-9cd9-789b6ad48887",
					Name = "Kheru Mind-Eater",
					ImageSmall = "https://cards.scryfall.io/small/front/e/6/e6246cf3-76bd-476b-9cd9-789b6ad48887.jpg?1562626991",
					ImageNormal = "https://cards.scryfall.io/normal/front/e/6/e6246cf3-76bd-476b-9cd9-789b6ad48887.jpg?1562626991",
					ImageLarge = "https://cards.scryfall.io/large/front/e/6/e6246cf3-76bd-476b-9cd9-789b6ad48887.jpg?1562626991",
					ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/e/6/e6246cf3-76bd-476b-9cd9-789b6ad48887.jpg?1562626991",
					Quantity = 2,
					Price = (decimal)0.91M
				},
				new Inventory
				{
					Id = "bf42524c-97e5-40b2-8a6d-d2a1f0a9eb65",
					Name = "Keldon Marauders",
					ImageSmall = "https://cards.scryfall.io/small/front/b/f/bf42524c-97e5-40b2-8a6d-d2a1f0a9eb65.jpg?1618940501",
					ImageNormal = "https://cards.scryfall.io/normal/front/b/f/bf42524c-97e5-40b2-8a6d-d2a1f0a9eb65.jpg?1618940501",
					ImageLarge = "https://cards.scryfall.io/large/front/b/f/bf42524c-97e5-40b2-8a6d-d2a1f0a9eb65.jpg?1618940501",
					ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/b/f/bf42524c-97e5-40b2-8a6d-d2a1f0a9eb65.jpg?1618940501",
					Quantity = 20,
					Price = (decimal)0.09M
                },
				new Inventory
				{
					Id = "0e0fa5ab-c4d1-4b2d-ad62-feb651e4b11c",
					Name = "Thraben Doomsayer",
					ImageSmall = "https://cards.scryfall.io/small/front/0/e/0e0fa5ab-c4d1-4b2d-ad62-feb651e4b11c.jpg?1591320182",
					ImageNormal = "https://cards.scryfall.io/normal/front/0/e/0e0fa5ab-c4d1-4b2d-ad62-feb651e4b11c.jpg?1591320182",
					ImageLarge = "https://cards.scryfall.io/large/front/0/e/0e0fa5ab-c4d1-4b2d-ad62-feb651e4b11c.jpg?1591320182",
					ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/0/e/0e0fa5ab-c4d1-4b2d-ad62-feb651e4b11c.jpg?1591320182",
					Quantity = 10,
					Price = (decimal)0.19M
                },
				new Inventory
				{
					Id = "033afbd5-9937-4957-98ba-48e469a490bb",
					Name = "Miscast",
					ImageSmall = "https://cards.scryfall.io/small/front/0/3/033afbd5-9937-4957-98ba-48e469a490bb.jpg?1594735579",
					ImageNormal = "https://cards.scryfall.io/normal/front/0/3/033afbd5-9937-4957-98ba-48e469a490bb.jpg?1594735579",
					ImageLarge = "https://cards.scryfall.io/large/front/0/3/033afbd5-9937-4957-98ba-48e469a490bb.jpg?1594735579",
					ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/0/3/033afbd5-9937-4957-98ba-48e469a490bb.jpg?1594735579",
					Quantity = 2,
					Price = (decimal)1.19M
                },

				 new Inventory
				 {
					 Id = "374b5d57-fd20-4062-9ec2-24ac557d9dde",
					 Name = "Mina and Denn, Wildborn",
					 ImageSmall = "https://cards.scryfall.io/small/front/3/7/374b5d57-fd20-4062-9ec2-24ac557d9dde.jpg?1604195020",
					 ImageNormal = "https://cards.scryfall.io/normal/front/3/7/374b5d57-fd20-4062-9ec2-24ac557d9dde.jpg?1604195020",
					 ImageLarge = "https://cards.scryfall.io/large/front/3/7/374b5d57-fd20-4062-9ec2-24ac557d9dde.jpg?1604195020",
					 ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/3/7/374b5d57-fd20-4062-9ec2-24ac557d9dde.jpg?1604195020",
					 Quantity = 4,
					 Price = (decimal)0.58M
				 });
		}

		public void SeedData()
		{
			// Check if the database has already been seeded
			if (BulkData.Any())
			{
				// If the database has been seeded, exit this method
				return;
			}

			// If the database has not been seeded, seed the databases.
			var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "infos", "AllCards.json");
			var jsonText = File.ReadAllText(jsonPath);
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
