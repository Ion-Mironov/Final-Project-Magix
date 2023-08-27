using Final___Magix.DataContext;
using Final___Magix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

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
				//fetch matching card data and add it to the trade-in


				ViewBag.BulkDataEntries = _dbContext.BulkData.ToList();
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
	}
}
