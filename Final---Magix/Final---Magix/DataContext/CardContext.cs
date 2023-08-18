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
        public DbSet<CardModel> Cards { get; set; } //represents the card collection
        public DbSet<TradeInModel> TradeIns { get; set; } //Historical trade-ins database
        public DbSet<InventoryModel> StoreInventory { get; set; } //Store Inventory atabase
        public DbSet<BulkData> BulkData { get; set; } //BulkDataModel.BulkData database (Id, Name, ImageId, PriceId)
        //public DbSet<Image> BulkImage { get; set; } //BulkDataModel.Images database (Id, Small, Normal, Large, BorderCrop)
        public DbSet<Price> BulkPrice { get; set; } //BulkDataModel.Price database (Id, Usd)

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// Seed initial store inventory data
            //modelBuilder.Entity<InventoryModel>().HasData(
            //    new InventoryModel { Id = 1, Name = "Card A", ImageUrl = "url", Price = 5.99m },
            //    new InventoryModel { Id = 2, Name = "Card B", ImageUrl = "url", Price = 3.49m }
            //// Add more items as needed
            //);

            //// Specify the column type, precision, and scale for the Price property
            //modelBuilder.Entity<InventoryModel>()
            //    .Property(i => i.Price)
            //    .HasColumnType("decimal(6, 2)"); // Adjust precision and scale as needed. Might need to be lowered.
            //modelBuilder.Entity<TradeInModel>().HasData(
            //    new TradeInModel { Id = 1 },
            //    new TradeInModel { Id = 2 }
            //    );

        }
        public void SeedData()
        {
            //Check if the database have already been seeded
            if (BulkData.Any() /*|| BulkImage.Any()*/ || BulkPrice.Any())
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
                    ImageBorderCrop = cardData.ImageBorderCrop
                };
                BulkData.Add(card);

                var CardPrice = new Price()
                {
                    Id = cardData.Id,
                    Usd = cardData.Prices.Usd
                };
                BulkPrice.Add(CardPrice);

                
            }
            SaveChanges();
        }
    }
}
