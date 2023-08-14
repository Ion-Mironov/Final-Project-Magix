using System.ComponentModel.DataAnnotations;

namespace Final___Magix.Models
	{
	public class CardModel
		{
		public int Id { get; set; }
		public int Price { get; set; }
		public string Image { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Condition { get; set; }

		[Required]
		public string Set { get; set; }

		[Required]
		public string Print { get; set; }

		[Required]
		public bool Foil { get; set; }
		}
	}
