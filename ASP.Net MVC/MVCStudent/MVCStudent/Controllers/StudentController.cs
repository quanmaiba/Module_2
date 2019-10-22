using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCStudent.Models;
using MVCStudent.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MVCStudent.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IGroupRepository groupRepository;
        private readonly MvcContext mvcContext;
        private readonly IHostingEnvironment hostingEnvironment;

        public StudentController(IStudentRepository studentRepository, IGroupRepository groupRepository, MvcContext mvcContext,
            IHostingEnvironment hostingEnvironment)
        {
            _studentRepository = studentRepository;
            this.groupRepository = groupRepository;
            this.mvcContext = mvcContext;
            this.hostingEnvironment = hostingEnvironment;
        }
        //[BindProperty]
        //public Student Student { get; set; }
        //[TempData]
        //public string Message { get; set; }
        // GET: Student
        public IActionResult Index()
        {

            StudentsListViewModel studentsListViewModel = new StudentsListViewModel();
            studentsListViewModel.Students = _studentRepository.GetStudentsAll;

            return View(studentsListViewModel);
        }
        [Authorize]
        public IActionResult List(string GroupName)
        {
            IEnumerable<Student> students;
            string CurrentGroup;

            if (string.IsNullOrEmpty(GroupName))
            {
                students = _studentRepository.GetStudentsAll.OrderBy(s => s.StudentId);
                CurrentGroup = "All student";
            }
            else
            {
                students = _studentRepository.GetStudentsAll.Where(g => g.Group.GroupName == GroupName)
                    .OrderBy(s => s.StudentId);
                CurrentGroup = groupRepository.GetGroupsAll.FirstOrDefault(g => g.GroupName == GroupName)?.GroupName;
            }

            return View(new StudentsListViewModel
            {
                Students = students,
                CurrentGroup = CurrentGroup
            });
        }
        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            var student = _studentRepository.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            //var selects = groupRepository.GetGroupsAll;

            ////ViewData["GroupId"] = new SelectList(selects);
            //ViewBag.Hero = mvcContext.Groups.ToList();
            //ViewData["Group"] = new SelectList(selects).ToList();
            StudentsListViewModel studentList = new StudentsListViewModel();

            studentList.Groups = new SelectList(groupRepository.GetGroupsAll, "GroupId", "GroupName");

            TempData["Message"] = null;

            return View(studentList);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StudentsListViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model);
                //if (model.Photos != null && model.Photos.Count > 0)
                //{
                //    foreach (IFormFile photo in model.Photos)
                //    {
                //        string uploadsFoder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                //        uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                //        string filePath = Path.Combine(uploadsFoder, uniqueFileName);
                //        photo.CopyTo(new FileStream(filePath, FileMode.Create));
                //    }
                //}

                Student newStudent = new Student
                {
                    Name = model.Student.Name,
                    UrlImage = uniqueFileName,
                    History = model.Student.History,
                    GroupId = model.Student.GroupId

                };
                _studentRepository.AddStudent(newStudent);
                var result = _studentRepository.Commit();

                if (result)
                {
                    TempData["Message"] = "Create Finish";
                }
                else
                {
                    TempData["Message"] = "Create Fails";
                }
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Details", new { id = newStudent.StudentId });
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            Student Student = new Student();
            StudentsEditViewModel studentsEditViewModel = new StudentsEditViewModel
            {

                Id = Student.StudentId,
                Name = Student.Name,
                ExistingPhotoPath = Student.UrlImage,
                Sex = Student.Sex,
                History = Student.History,
                GroupId = Student.GroupId
            };
            studentsEditViewModel.Groups = new SelectList(groupRepository.GetGroupsAll, "GroupId", "GroupName");
            return View(studentsEditViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(StudentsEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var student = _studentRepository.GetStudentById(model.Id);
                //student.Name = model.Name; student.History = model.History;
                //student.Sex = model.Sex;
                if (model.Photos != null)
                {
                    if (model.ExistingPhotoPath != null)
                    {
                        string uploadsFoder = Path.Combine(hostingEnvironment.WebRootPath, "images", model.ExistingPhotoPath);
                        System.IO.File.Delete(uploadsFoder);
                    }
                    student.UrlImage = ProcessUploadedFile(model);
                }

                _studentRepository.UpdateStudent(student);
                var result = _studentRepository.Commit();

                if (result)
                {
                    TempData["Message"] = "Create Finish";
                }
                else
                {
                    TempData["Message"] = "Create Fails";
                }
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Index");
            }
            return View(model);
        }

        private string ProcessUploadedFile(StudentsListViewModel model)
        {
            string uniqueFileName = null;
            if (model.Photos != null)
            {
                string uploadsFoder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photos.FileName;
                string filePath = Path.Combine(uploadsFoder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photos.CopyTo(fileStream);
                }

            }
            return uniqueFileName;
        }

        // POST: Student/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(Student student)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _studentRepository.AddStudent(student);

        //        var result = _studentRepository.Commit();

        //        if (result)
        //        {
        //            TempData["Message"] = "Create Finish";
        //        }
        //        else
        //        {
        //            TempData["Message"] = "Create Fails";
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View();
        //}

        // GET: Student/Edit/5
        //public IActionResult Edit(int id)
        //{
        //    var selects = groupRepository.GetGroupsAll;
        //    ViewData["Group"] = mvcContext.Groups.ToList();
        //    TempData["Message"] = null;
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    var student = _studentRepository.GetStudentById(id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(student);
        //}

        // POST: Student/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(int id, Student student)
        //{
        //    if (id != student.StudentId)
        //    {
        //        return NotFound();
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        _studentRepository.UpdateStudent(student);

        //        var result = _studentRepository.Commit();

        //        if (result)
        //        {
        //            TempData["Message"] = "Update Finish";
        //        }
        //        else
        //        {
        //            TempData["Message"] = "Update Fails";
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View();
        //}

        // GET: Student/Delete/5
        public IActionResult Delete(int id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var student = _studentRepository.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, bool c)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _studentRepository.DeleteStudent(id);

                var result = _studentRepository.Commit();

                if (result)
                {
                    TempData["Message"] = "Delete Finish";
                }
                else
                {
                    TempData["Message"] = "Delete Fails";
                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}