using GameLOL.WebData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GameLOL.WebData.Controllers
{
    public class quanController : Controller
    {
        //HttpContext ctx;
        //public quanController(IHttpContextAccessor _ctx)
        //{
        //    ctx = _ctx.HttpContext;
        //}

        //[Route("quan/sua")]
        public List<quan> quan = new List<quan>()
        {
            new quan()
            {
                Id =1, Name = "anh quân",Avalible = true,Price = 10000, Khuyenmai=80000
            },
              new quan()
            {
                Id =2, Name = "anh quân 1",Avalible = true,Price = 12000, Khuyenmai=2000
            }
        };
        public IActionResult Index(int id)
        {
            //var models = new quan();
            //models.Message = "Helo anh quan " + id;
            return View(quan);
            //(await _context.RoleSkins.ToListAsync()

            //ctx.Response.StatusCode = 200;
            //ctx.Response.ContentType = "text/html";
            //ctx.Response.Headers.Add("SomeHeader", "Value");
            //byte[] context = Encoding.ASCII.GetBytes("<html><body>Hello Anh quân </ body >< /html > ");
            ////await ctx.Response.Body.WriteAsync(context, 0, context.Length);
            //return Content("Hello Anh quan");
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(quan quan)
        {
            return RedirectToAction("Index", "quan");
        }

        [HttpGet("{id}")]
        public List<quan> GetAll(string id)
        {
            return new List<quan>();
        }
        //post: quan
        [HttpPost()]
        public IActionResult Create(quan quan)
        {
            return Ok();
        }

        //Put: quan/10
        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody]quan quan)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            return Ok();
        }
    }
}