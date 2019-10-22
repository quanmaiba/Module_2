using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCStudent.Models;
using System.Collections.Generic;

namespace MVCStudent.Controllers
{
    public class GroupController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IGroupRepository groupRepository;
        private readonly MvcContext mvcContext;

        public GroupController(IStudentRepository studentRepository, IGroupRepository groupRepository, MvcContext mvcContext)
        {
            _studentRepository = studentRepository;
            this.groupRepository = groupRepository;
            this.mvcContext = mvcContext;
        }
        //[BindProperty]
        //public Student Student { get; set; }
        [TempData]
        public string Message { get; set; }
        public IEnumerable<Group> Groups { get; set; }
        // GET: Student
        public IActionResult Index()
        {
            Groups = groupRepository.GetGroupsAll;
            return View(Groups);
        }
        // GET: Group/Details/5
        public IActionResult Create()
        {
            //var selects = groupRepository.GetGroupsAll;

            ////ViewData["GroupId"] = new SelectList(selects);
            //ViewBag.Hero = mvcContext.Groups.ToList();
            //ViewData["Group"] = new SelectList(selects).ToList();


            return View();
        }

        // POST: Student/Create
        [HttpPost]

        public IActionResult Create(Group student)
        {
            if (ModelState.IsValid)
            {
                groupRepository.AddGroup(student);

                var result = groupRepository.Commit();

                if (result)
                {
                    TempData["Message"] = "Create Finish";
                }
                else
                {
                    TempData["Message"] = "Create Fails";
                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // POST: Group/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Group/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Group/Edit/5
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

        // GET: Group/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Group/Delete/5
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