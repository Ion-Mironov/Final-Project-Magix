using Final___Magix.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Final___Magix.Controllers
	{
	public class TradeInController : Controller
		{
		private readonly CardContext _dbContext;
		public TradeInController(CardContext dbContext)
			{
			_dbContext = dbContext;
			}

		public ActionResult Index()
		// GET: TradeInController
			{
			var tradein = _dbContext.TradeIns.ToList();
			return View(tradein);
			}

		// GET: TradeInController/Details/5
		public ActionResult Details(int id)
			{
			return View();
			}

		// GET: TradeInController/Create
		[HttpGet]
		public IActionResult Create()
			{
			return View();
			}

		// POST: TradeInController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
			{
			try
				{
				ViewBag.BulkDataEntries = _dbContext.BulkData.ToList();		// Fetch matching card data and add it to the trade-in
				return View();
				}
			catch
				{
				return View();
				}
			}

		// GET: TradeInController/Delete/5
		public ActionResult Delete(int id)
			{
			return View();
			}

		// POST: TradeInController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
			{
			try
				{
				return RedirectToAction(nameof(Index));
				}
			catch
				{
				return View();
				}
			}

		// Get all Name properties from the BulkData db table and store them in a list
		public IActionResult ValidateCardName(string cardName)
			{
			var bulkDataNames = _dbContext.BulkData.Select(data => data.Name).ToList();
			var isValid = bulkDataNames.Contains(cardName);
			return Ok(new { isValid = isValid });
			}

		[HttpGet]
		public IActionResult GetMatchingCards(string cardName)
			{
			var matchingCardNames = _dbContext.BulkData
				.Where(card => card.Name.ToLower().Contains(cardName))
				.ToList();

			return Json(new { matchingCardNames });
			}

		//[HttpPost]
		//public IActionResult CreateTradeIn(object[] cards)
		//{
		//	// convert array of card objects into the proper type to store in the tradein db
		//	List<CardModel> _cards = new();
		//	foreach (var obj in cards)
		//	{
		//		if (obj is CardModel cardModel)
		//		{
		//			_cards.Add(new CardModel
		//			{
		//				Id = cardModel.Id,
		//				Name = cardModel.Name,
		//				Condition = cardModel.Condition,
		//				Set = cardModel.Set,
		//				Foil = cardModel.Foil,
		//				Quantity = cardModel.Quantity,
		//				Price = cardModel.Price,
		//			});
		//		}
		//	}
		//	//try to add the instance of the tradein to the db
		//	try
		//	{
		//		using (var connection = _dbContext.Database.GetDbConnection())
		//		{
		//			// Some wizardry... Don't ask.
		//			connection.Open();
		//			using (var cmd = connection.CreateCommand())
		//			{
		//				cmd.CommandText = "SET IDENTITY_INSERT TradeIns ON";
		//				cmd.ExecuteNonQuery();
		//			}
		//			var totalTradeInEntries = _dbContext.TradeIns.Count();
		//			if (totalTradeInEntries! >= 0) { totalTradeInEntries = 0; }
		//			var tradeIn = new TradeInModel
		//			{
		//				Id = totalTradeInEntries + 1,
		//				Cards = _cards
		//                  };
		//			_dbContext.TradeIns.Add(tradeIn);
		//			_dbContext.SaveChanges();

					using (var cmd = connection.CreateCommand())
					{
						cmd.CommandText = "SET IDENTITY_INSERT TradeIns OFF";
						cmd.ExecuteNonQuery();
					}
				}
				return RedirectToAction("Index");
			}
			catch (Exception ex)
			{
				//handle exceptions here
				return RedirectToAction("Error", "Home");
			}
		}

		[HttpPost]
		public IActionResult IncrementQuantity()
		{
			var inventoryItem = _dbContext.StoreInventory.FirstOrDefault(cards => cards.Name == "Balthor the Defiled");
			var inventoryItem1 = _dbContext.StoreInventory.FirstOrDefault(cards => cards.Name == "Herd Migration");

			if (inventoryItem != null && inventoryItem1 != null)
			{
				inventoryItem.Quantity += 2;
				inventoryItem1.Quantity += 3;
				_dbContext.SaveChanges();
			}


			return RedirectToAction("Index", "StoreInventory"); // Redirect to store inventory page
		}

		//			using (var cmd = connection.CreateCommand())
		//			{
		//				cmd.CommandText = "SET IDENTITY_INSERT TradeIns OFF";
		//				cmd.ExecuteNonQuery();
		//			}
		//		}
		//		return RedirectToAction("Index");
		//	}
		//	catch (Exception ex)
		//	{
		//		//handle exceptions here
		//		return RedirectToAction("Error", "Home");
		//	}
		//}

		}	// Closing public class TradeInController : Controller

	}   // Closing namespace Final___Magix.Controllers
