using System.ComponentModel.DataAnnotations;

namespace Final___Magix.Models
	{
	public class CardModel
		{
		[Key]
		public string Id { get; set; }          // Name of the card

		public decimal Price { get; set; }      // Card's worth
		public string Image { get; set; }       // URL for the card picture

		[Required]
		public string Name { get; set; }        // Unique identifier for each card

		[Required]
		public string Condition { get; set; }

		[Required]
		public string Set { get; set; }         // Which group the card belongs to

		[Required]
		public bool Foil { get; set; }          // Whether the card is shiny or not

		public int Quantity { get; set; }
		}
	}
