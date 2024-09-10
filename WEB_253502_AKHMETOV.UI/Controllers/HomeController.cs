using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEB_253502_AKHMETOV.UI.Models;

namespace WEB_253502_AKHMETOV.UI.Controllers
{
    public class HomeController : Controller
    {
        //GET: HomeController

        [ViewData]
        public string Name { get; set; } = "LAB 2";
        
        public string listName { get; set; }
        public SelectList list { get; set; }
        public ActionResult Index()
        {
            var elements = new List<ListDemo> { 
                new ListDemo(1, "Uno"),
                new ListDemo(2, "Dos"),
                new ListDemo(3, "Tres"),
                new ListDemo(4, "Quatro"),
            };

            this.list = new SelectList(elements, nameof(ListDemo.Id), nameof(ListDemo.Name));
            //var l = new SelectList();
            ViewBag.list = this.list;
            return View();
        }

       
        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
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

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
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

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
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
