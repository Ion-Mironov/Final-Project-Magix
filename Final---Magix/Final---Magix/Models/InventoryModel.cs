using System.ComponentModel.DataAnnotations;

namespace Final___Magix.Models
	{
	public class InventoryModel
		{
		[Required]
		public int Id { get; set; }
		public string CName { get; set; }
		[Required]
		public string CImageUrl { get; set; }
		public decimal Price { get; set; }
		}
	}
