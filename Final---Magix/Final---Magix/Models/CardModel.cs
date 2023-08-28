using System.ComponentModel.DataAnnotations;

namespace Final___Magix.Models
	{
	public class CardModel
		{
		[Key]
		public int Id { get; set; }				// Name of the card

		public decimal Price { get; set; }		// Card's worth
		public string Image { get; set; }		// URL for the card picture

		[Required]
		public string Name { get; set; }		// Unique identifier for each card

		[Required]
		public string Condition { get; set; }

		[Required]
		public string Set { get; set; }         // Which group the card belongs to

		[Required]
		public bool Foil { get; set; }			// Whether the card is shiny or not

		//Potentially need to add a quantity property to hold the number of the specific card during tradein
		//Might not need to if we implement it properly in the confirmtradein.js
		}
	}
