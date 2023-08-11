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


		}
	}