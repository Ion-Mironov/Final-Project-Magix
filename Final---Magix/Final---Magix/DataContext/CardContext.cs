//using Final___Magix.Models;
//using Microsoft.EntityFrameworkCore;

//namespace Final___Magix.DataContext
//	{
//	public class CardContext : DbContext
//		{
//		private const string CONNECTION_STRING = "Server=(localdb)\\mssqllocaldb;Database=Final---Magix;Trusted_Connection=True;MultipleActiveResultSets=true";

//		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//			{
//			optionsBuilder.UseSqlServer(CONNECTION_STRING);
//			}
//		public DbSet<CardModel> Cards { get; set; }

//		public DbSet<TradeInModel> TradeIns { get; set; }

//		}
//	}


using Final___Magix.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Final___Magix.DataContext
{
    public class CardContext : DbContext
    {
        private const string CONNECTION_STRING = "Server=(localdb)\\mssqllocaldb;Database=Final---Magix;Trusted_Connection=True;MultipleActiveResultSets=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }
        public DbSet<CardModel> Cards { get; set; }// represents the card collection

        public DbSet<TradeInModel> TradeIns { get; set; }// represent trades
        public DbSet<InventoryModel> StoreInventory { get; set; }
        public DbSet<BulkData> BulkData { get; set; }
        public DbSet<Image_Uris> ImageUri { get; set; }
        //public DbSet<Prices> Prices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed initial store inventory data
            modelBuilder.Entity<InventoryModel>().HasData(
                new InventoryModel { Id = 1, Name = "Card A", ImageUrl = "url", Price = 5.99m },
                new InventoryModel { Id = 2, Name = "Card B", ImageUrl = "url", Price = 3.49m }
            // Add more items as needed
            );

            // Specify the column type, precision, and scale for the Price property
            modelBuilder.Entity<InventoryModel>()
                .Property(i => i.Price)
                .HasColumnType("decimal(6, 2)"); // Adjust precision and scale as needed. Might need to be lowered.
            modelBuilder.Entity<TradeInModel>().HasData(
                new TradeInModel { Id = 1 },
                new TradeInModel { Id = 2 }
                );

            //create the file path
            //var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "infos", "AllCards.json");
            ////Read the file into a var
            //var jsonText = File.ReadAllText(jsonPath);
            ////Deserialize the var into List<BulkDataModel>
            //var cardList = JsonConvert.DeserializeObject<List<BulkDataModel>>(jsonText);
            //Iterate through cardList to populate the BulkData db table with the objects created...

            //modelBuilder.Entity<BulkDataModel.BulkData>();

            var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "infos", "AllCards.json");
            //Read the file into a var
            var jsonText = File.ReadAllText(jsonPath);
            //Deserialize the var into List<BulkDataModel>
            var cardList = JsonConvert.DeserializeObject<List<BulkData>>(jsonText);
            var cardObjs = new List<BulkData>();
            var cardImgsList = new List<Image_Uris>();
            foreach (var cardData in cardList)
            {
                var card = new BulkData()
                {
                    Id = cardData.Id,
                    Name = cardData.Name,
                    //Prices
                    //Images

                };
                cardObjs.Add(card);
                //Populate Prices with JSON data (cardData.Prices
                //var cardPrice = new Prices()
                //{
                //    cardPrice.Usd = (decimal)cardData.Price.Usd;
                //};

                //Populate the imageUri db table
                
                var cardImgs = new Image_Uris()
                {
                    Id = cardData.Id,
                    Small = cardData.ImageUris.Small,
                    Normal = cardData.ImageUris.Normal,
                    Large = cardData.ImageUris.Large,
                    BorderCrop = cardData.ImageUris.BorderCrop
                };
                cardImgsList.Add(cardImgs);
            }
            modelBuilder.Entity<BulkData>().HasData(cardObjs);



        }
        //public List<BulkData> Test()
        //{



    }
}
