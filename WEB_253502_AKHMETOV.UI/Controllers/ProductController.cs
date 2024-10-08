﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using WEB_253502_AKHMETOV.Domain.Entities;
using WEB_253502_AKHMETOV.Domain.Models;
using WEB_253502_AKHMETOV.UI.Services.CategoryService;
using WEB_253502_AKHMETOV.UI.Services.ProductService;

namespace WEB_253502_AKHMETOV.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService _service, ICategoryService _category) {
            this._productService = _service;
            this._categoryService = _category;
        }

        public async Task<IActionResult> Index(string? category, int? page) {
            
            var productResponse = await _productService.GetProductListAsync(category, page.Value);
            var categories = await _categoryService.GetCategoryListAsync();

            if (!productResponse.Successfull || productResponse is null) { 
                return NotFound(productResponse?.ErrorMessage);
            }

            ViewData["currentCategory"] = category != "all" ? categories.Data?.Find(c => c.NormalizedName.Equals(category))?.Name : "Все";
            ViewData["categories"] = _categoryService.GetCategoryListAsync().Result.Data;
            ViewData["totalPages"] = productResponse.Data?.TotalPages;

            return View(new ListModel<Dish> { Items = productResponse.Data!.Items, CurrentPage = 1, TotalPages = 1 });
        }
        // GET: ProductController
        

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
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

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
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

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
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
