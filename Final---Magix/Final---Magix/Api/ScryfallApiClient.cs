using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json; // Add this namespace for JSON serialization


namespace Final___Magix.Api
	{
	public class ScryfallApiClient
		{
		private readonly HttpClient _httpClient;

		public ScryfallApiClient(HttpClient httpClient)
			{
			_httpClient = httpClient;
			_httpClient.BaseAddress = new Uri("https://api.scryfall.com/");
			}

		public async Task<CardApiResponse> GetCardsAsync()
			{
			HttpResponseMessage response = await _httpClient.GetAsync("cards");

			if (response.IsSuccessStatusCode)
				{
				// Read the response content as a string
				string content = await response.Content.ReadAsStringAsync();

				// Deserialize the JSON content using JsonSerializer
				var cards = JsonSerializer.Deserialize<CardApiResponse>(content);

				// Return the deserialized card data
				return cards;
				}
			else
				{
				// Handle API error or return null/error response
				return null;
				}
			}
		}
	}
