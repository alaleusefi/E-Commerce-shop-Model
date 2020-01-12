using Model;
using Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controllers
{
    public class ProductsListController : Controller
    {
        private readonly IProductService ProductService;
        public ProductsListController(IProductService productService)
        {
            ProductService = productService;
        }
        public async Task<IActionResult> Index()
        {
            return View("~/Views/ProductsList.cshtml", await ProductService.GetAll());
        }
        public IActionResult Add()
        {
            return View("~/Views/ProductEntre.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            throw new NotImplementedException();
        }

        public IActionResult Edit(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            throw new NotImplementedException();
        }

        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
