using Microsoft.AspNetCore.Mvc;
using Mvc.Models.Student;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Mvc.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var todo = new List<StudenView>();
            var url = $"{Common.Common.ApiUrlStudent}/Students/Get";
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
                todo = JsonConvert.DeserializeObject<List<StudenView>>(responseData);
            }

            return View(todo);
            
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudenView collection)
        {

            int result = 0;
            var url = $"{Common.Common.ApiUrlStudent}/Students/Create";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var stremWrite = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(collection);
                stremWrite.Write(json);

            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var resResult = streamReader.ReadToEnd();
                //result = int.Parse(resResult);
            }
            //if (result > 0)
            //{
            //    TempData["Success"] = "Ok ";
            //}
            //else
            //{
            //    TempData["Fails"] = "Fails";
            //}
            return View();
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

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            var todo = new StudenView();
            var url = $"{Common.Common.ApiUrlStudent}/Students/GetById/{id}";
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
                todo = JsonConvert.DeserializeObject<StudenView>(responseData);
            }

            return View(todo);
        }

        // POST: Student/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(StudenView collection)
        {
            int id = collection.Id;
            int result = 0;
            var url = $"{Common.Common.ApiUrlStudent}/Students/Update";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";
            using (var stremWrite = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(collection);
                stremWrite.Write(json);

            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var resResult = streamReader.ReadToEnd();
                //result = int.Parse(resResult);
            }
            //if (result > 0)
            //{
            //    TempData["Success"] = "Ok ";
            //    ModelState.Clear();
            //}
            //else
            //{
            //    TempData["Fails"] = "Fails";
            //}
            return View(new StudenView() { });
           
        }

        // GET: Student/Delete/5      
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var result = false;
            var url = $"{Common.Common.ApiUrlStudent}/Students/Delete/{id}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "DELETE";
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
                result = JsonConvert.DeserializeObject<bool>(responseData);          
            }

            return RedirectToAction("Index","Student");
        }
    }
}