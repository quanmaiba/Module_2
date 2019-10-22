using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AnhQuan.Controllers
{
    public class EXController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}