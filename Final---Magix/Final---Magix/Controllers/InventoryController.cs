//using Final___Magix.DataContext;
//using Microsoft.AspNetCore.Mvc;

//namespace Final___Magix.Controllers
//	{
//	public class InventoryController : Controller
//		{
//		public IActionResult Index()
//			{
//			return View();
//			}
//		}
//	}


using Final___Magix.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; // Include the IFormCollection namespace
using Final___Magix.Api;
using Microsoft.EntityFrameworkCore;
using Final___Magix.Models;

namespace Final___Magix.Controllers
	{
	public class InventoryController : Controller
		{
		private readonly CardContext _dbContext;
		private readonly ScryfallApiClient _scryfallApiClient;

		public InventoryController(CardContext dbContext, ScryfallApiClient scryfallApiClient)
			{
			_dbContext = dbContext;
			_scryfallApiClient = scryfallApiClient;
			}

/*		public IActionResult BrowseInventory()
			{
			// Fetch inventory from your database
			var inventory = _dbContext.StoreInventory.ToList();

			//// Fetch additional card data from Scryfall API
			//foreach (var item in inventory)
			//	{
			//	var scryfallApiResponse = _scryfallApiClient.GetCardByName(item.Name);
			//	if (scryfallApiResponse != null)
			//		{
			//		// Assuming Scryfall API provides an image URL, you might want to use that.
			//		item.ImageUrl = scryfallApiResponse.ImageUrl;
			//		}
			//	}

			return View("Index", inventory);  // Pass the inventory list to the Index view
			}*/

		// GET: InventoryController
		public ActionResult Index()
		{
			var inventoryData = _dbContext.StoreInventory
				.Include(i => i.Prices) // Assuming there's a navigation property between Inventory and InventoryPrice
				.Select(i => new Inventory
				{
					Id = i.Id,
					Name = i.Name,
					ImageNormal = i.ImageNormal,
					Quantity = i.Quantity,
					Prices = i.Prices
				})
				.ToList();

			return View(inventoryData);
		}

		// GET: InventoryController/Details/5
		public ActionResult Details(int id)
			{
			return View();
			}

		// GET: InventoryController/Create
		public ActionResult Create()
			{
			return View();
			}

		// POST: InventoryController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
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

		// GET: InventoryController/Edit/5
		public ActionResult Edit(int id)
			{
			return View();
			}

		// POST: InventoryController/Edit/5
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

		// GET: InventoryController/Delete/5
		public ActionResult Delete(int id)
			{
			return View();
			}

		// POST: InventoryController/Delete/5
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
		}
	}
