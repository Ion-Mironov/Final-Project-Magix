using Final___Magix.Models;

namespace Final___Magix.Api
	{
	public class CardApiResponse
		{
		// This class represents the structure of the Scryfall API response when fetching cards.

		// The "Data" property holds the list of cards returned by the API.
		public List<CardModel> Data { get; set; }

		// You can add more properties here to match other parts of the API response if needed.
		// For example:
		// public string Object { get; set; }
		// public int TotalCards { get; set; }
		// ...

		// If the API response structure has nested objects or arrays, you would create corresponding classes
		// and use them as property types here. For example, if the API response contains "Images" property,
		// you would create an "Images" class and add:
		// public Images Images { get; set; }
		}
	}
