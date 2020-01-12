using Model;
using Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controllers
{
    public class ProductsListController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/ProductsList.cshtml", Database.Books);
        }
        public IActionResult Add()
        {
            return View("~/Views/ProductEntre.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            Database.Books.Add(book);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var product = Database.Books.Single(p => p.ID == id);
            return View("~/Views/ProductEntre.cshtml", product);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            var result = Database.Books.Single(p => p.ID == book.ID);
            result.Name = book.Name;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var book = Database.Books.Single(p => p.ID == id);
            Database.Books.Remove(book);
            return RedirectToAction("Index");
        }
    }
}
