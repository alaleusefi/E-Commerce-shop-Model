using WorldRemit.Model;
using WorldRemit.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldRemit.Controllers
{
    public class ProductsListController : Controller
    {
        [Route("string")]
        public string String()
        {
            return "This is a string from a controller";
        }
        
        public IActionResult Index()
        {
          
            return View("~/Views/ProductsList.cshtml", Database.Products);
        }
        public IActionResult Add()
        {
            return View("~/Views/ProductEntre.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            Database.Products.Add(product);
            return RedirectToAction("Index");

        }

        
        public IActionResult Edit(int id)
        {
            var product = Database.Products.Single(p => p.ID == id);
            return View("~/Views/ProductEntre.cshtml", product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var result = Database.Products.Single(p => p.ID == product.ID);
            result.Name = product.Name;
            result.Company = product.Company;
            return RedirectToAction("Index");            
        }

        public IActionResult Delete(int id)
        {
            var product = Database.Products.Single(p => p.ID == id);
            Database.Products.Remove(product);
            return RedirectToAction("Index");
        }


    }
}
