using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnhQuan.Models;

namespace AnhQuan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        [HttpGet]
        public JsonResult LoadData()
        {
            var listEm = new List<EmployeeModel>();
            listEm.Add(new EmployeeModel()
            {
                ID = 1,
                Name = "mai bá quân vip",
                Salary = 23000,
                Status = true
            });
            listEm.Add(new EmployeeModel()
            {
                ID = 2,
                Name = "mai bá quân pro",
                Salary = 29000,
                Status = true
            });
            listEm.Add(new EmployeeModel()
            {
                ID = 3,
                Name = "mai bá quân dn",
                Salary = 53000,
                Status = true
            });
            return Json(new
            {
                data = listEm,
                status = true
            });
        }
        public JsonResult
    }
}
