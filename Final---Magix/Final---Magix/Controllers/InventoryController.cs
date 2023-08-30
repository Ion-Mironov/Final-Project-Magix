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


        // GET: InventoryController
        public ActionResult Index()
        {

            var inventoryData = _dbContext.StoreInventory.ToList();




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
        [HttpPost]
        public IActionResult UpdateInventory([FromBody] List<CardModel> cards)
        {

            foreach (var card in cards)
            {
                //check to see if the card is already present in the store inventory db
                var storeCardCheck = _dbContext.StoreInventory.FirstOrDefault(c => c.Id == card.Id);
                //if inventory has the card already, update the inventory entry
                if (storeCardCheck != null)
                {
                    storeCardCheck.Quantity += card.Quantity;
                }
                //if the inventory does not have the card, create the entry for it instead
                if (storeCardCheck == null)
                {
                    var bulkDataMatch = _dbContext.BulkData.FirstOrDefault(b => b.Id == card.Id);
                    var storeNewCard = new Inventory()
                    {
                        Id = card.Id,
                        Name = card.Name,
                        ImageSmall = bulkDataMatch.ImageSmall,
                        ImageNormal = bulkDataMatch.ImageNormal,
                        ImageLarge = bulkDataMatch.ImageLarge,
                        ImageBorderCrop = bulkDataMatch.ImageBorderCrop,
                        Price = card.Price,
                        Quantity = card.Quantity,
                    };
                    _dbContext.StoreInventory.Add(storeNewCard);
                }
            }
            try
            {
                _dbContext.SaveChanges();
                return Json(new { success = true, message = "Inventory update success." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "An error occurred while trying to update the inventory. ", error = ex.Message });
            }
        }
    }
}
