using System.ComponentModel.DataAnnotations;

namespace Final___Magix.Models
	{
	public class InventoryModel
		{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string ImageUrl { get; set; }

		[Required]
		public decimal Price { get; set; }

		[Required]
		public int Quantity { get; set; }

		}
	}
