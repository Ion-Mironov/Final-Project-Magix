using Final___Magix.Models;
using Microsoft.EntityFrameworkCore;

namespace Final___Magix.DataContext
	{
	public class CardContext : DbContext
		{
		private const string CONNECTION_STRING = "Server=(localdb)\\mssqllocaldb;Database=Final---Magix;Trusted_Connection=True;MultipleActiveResultSets=true";

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			{
			optionsBuilder.UseSqlServer(CONNECTION_STRING);
			}
		public DbSet<CardModel> Cards { get; set; }

		public DbSet<TradeInModel> TradeIns { get; set; }

		public DbSet<InventoryModel> StoreInventory { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
			{
			// Seed initial store inventory data
			modelBuilder.Entity<InventoryModel>().HasData(
				new InventoryModel { Id = 1, CName = "Card A", CImageUrl = "url", Price = 5.99m },
				new InventoryModel { Id = 2, CName = "Card B", CImageUrl = "url", Price = 3.49m }
			// Add more items as needed
			);

			// Specify the column type, precision, and scale for the Price property
			modelBuilder.Entity<InventoryModel>()
				.Property(i => i.Price)
				.HasColumnType("decimal(18, 2)"); // Adjust precision and scale as needed, personally i think it could be lower but check with group.
			}
		}
	}
