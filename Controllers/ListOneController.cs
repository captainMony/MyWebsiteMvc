using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWebsiteMvc.Controllers
{
    public class ListOneController : Controller
    {
        // GET: ListOneController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ListOneController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ListOneController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ListOneController/Create
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

        // GET: ListOneController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ListOneController/Edit/5
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

        // GET: ListOneController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ListOneController/Delete/5
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
