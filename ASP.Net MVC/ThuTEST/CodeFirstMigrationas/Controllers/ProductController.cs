using CodeFirstMigrationas.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CodeFirstMigrationas.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            foreach (var modelStateKeys in ModelState.Keys)
            {
                var modelStareVal = ModelState[modelStateKeys];
                foreach (var error in modelStareVal.Errors)
                {
                    var key = modelStateKeys;
                    var errorMessage = error.ErrorMessage;

                }
            }
            //if (string.IsNullOrEmpty(product.Name))
            //{
            //    Console.WriteLine("Failed");
            //}
            string message = "";
            if (ModelState.IsValid)
            {
                //if (someSever.IsProducct(product))
                //{
                //    ModelState.AddModelError("", "Product Exists");
                //}
                //else
                //{
                //    return View(product);
                //}
                message = "product" + product.Name + "Rate " + product.Rate.ToString() + "With Ratting " + product.Racting.ToString() + "Create";
            }
            else
            {
                return View(product);
            }
            return Content(message);
        }
    }
}