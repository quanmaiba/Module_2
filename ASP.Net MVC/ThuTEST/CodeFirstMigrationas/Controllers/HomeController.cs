using CodeFirstMigrationas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeFirstMigrationas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Test"] = "hello";
            //ViewBag.Test?.Name = new ErrorViewModel() { };
            ViewBag.Customer = new Customer();
            Customer customer = new Customer();
            return View(customer);
        }

        public IActionResult Privacy()
        {
            ViewData.Model = new Customer();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult Create()
        {
            ErrorViewModel model = new ErrorViewModel();
            return View(model);
        }
    }
}
