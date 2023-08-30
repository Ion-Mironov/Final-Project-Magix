using Final___Magix.DataContext;
using Microsoft.AspNetCore.Mvc;

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
				IncrementQuantity();
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

			return RedirectToAction("Index", "Inventory");		// Redirect to store inventory page
			}

		}   // Closing public class TradeInController : Controller

	}   // Closing namespace Final___Magix.Controllers
