using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mvc.Models.TodoItem;
using Newtonsoft.Json;

namespace Mvc.Controllers
{
    public class TodoItemController : Controller
    {
        [TempData]
        public string Success { get; set; }
        [TempData]
        public string Fails { get; set; }
        // GET: TodoItem
        public ActionResult Index()
           
        {
            var todo = new List<TodoItemView>();
            var url = $"{Common.Common.ApiUrl}/TodoItems";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream stream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(stream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {

                    ((IDisposable)stream).Dispose();
                }
                todo = JsonConvert.DeserializeObject<List<TodoItemView>>(responseData);
            }
            
            return View(todo);
        }

        // GET: TodoItem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TodoItem/Create
        public ActionResult Create()
        {
            TempData["Success"] = null;
            TempData["Fails"] = null;
            return View();
        }

        // POST: TodoItem/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(TodoItem collection)
        {
            int result = 0;
            var url = $"{Common.Common.ApiUrl}/todo/create";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";          
            using(var stremWrite = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(collection);
                stremWrite.Write(json);

            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var resResult = streamReader.ReadToEnd();
                result = int.Parse(resResult);
            }
            if (result > 0)
            {
               TempData["Success"]="Ok ";
            }
            else
            {
                TempData["Fails"] = "Fails";
            }
            return View(new TodoItem() { });
                //try
                //{
                //    // TODO: Add insert logic here

                //    return RedirectToAction(nameof(Index));
                //}
                //catch
                //{
                //    return View();
                //}
        }

        // GET: TodoItem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TodoItem/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TodoItem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TodoItem/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}