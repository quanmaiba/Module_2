using Microsoft.AspNetCore.Mvc;

namespace MVCStudent.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}