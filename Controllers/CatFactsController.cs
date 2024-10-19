using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Recipehub.Models;
namespace Recipehub.Controllers
{
    public class CatFactsController : Controller
    {
        HttpClient client = new HttpClient();
        // GET: CatController1
        public async Task<IActionResult> Index()
        {
            string url = "https://catfact.ninja/fact";
            var response = await client.GetStringAsync(url);
            var catFact = JsonConvert.DeserializeObject<CatFact>(response);

            return View(catFact);
        }

        // GET: CatFactsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CatFactsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CatFactsController/Create
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

        // GET: CatFactsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CatFactsController/Edit/5
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

        // GET: CatFactsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CatFactsController/Delete/5
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
