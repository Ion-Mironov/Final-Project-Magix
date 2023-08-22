using Final___Magix.DataContext;
using Final___Magix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
		public ActionResult Create()
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
				// Get the card name entered by the user from the form collection
				string cardName = collection["cardName"];

				// Your logic to retrieve matching cards based on the entered card name
				IEnumerable<TradeInModel> matchingCards = GetMatchingCards(cardName);

				// Pass the matching cards to the view
				return View("Create", matchingCards); // You might want to rename the view to match your file name
			}
			catch
			{
				return View();
			}
		}

		// GET: TradeInController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: TradeInController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
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
		// Logic to retrieve matching cards based on card name
		private IEnumerable<TradeInModel> GetMatchingCards(string cardName)
		{
			// Example query: Retrieve cards whose name contains the entered card name
			return _dbContext.TradeIns.Where(card => card.CardName.Contains(cardName)).ToList();
		}
	}
}
