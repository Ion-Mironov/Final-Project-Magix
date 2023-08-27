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
        //*//
        [HttpGet]
        public IActionResult GetMatchingCardNames(string term)
        {
            var matchingCardNames = _dbContext.Cards
                .Where(card => card.Name.ToLower().Contains(term))
                .Select(card => card.Name)
                .ToList();

            return Json(matchingCardNames);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                string cardName = collection["cardName"];

                IEnumerable<string> matchingCards = _dbContext.Cards
                    .Where(card => card.Name.ToLower().Contains(cardName.ToLower()))
                    .Select(card => card.Name)
                    .ToList();

                ViewBag.BulkDataEntries = _dbContext.BulkData.ToList();
                ViewBag.MatchingCards = matchingCards;

                // Add your trade-in creation logic here

                return View();
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
			return _dbContext.TradeIns.Where(card => cardName.Contains(cardName)).ToList();
		}
	}
}
