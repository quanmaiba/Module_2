using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Model;

namespace StudentAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentsController( IStudentRepository studentRepository)
        {      
            _studentRepository = studentRepository;
        }

        [BindProperty]
        public Student Student { get; set; }
        public IEnumerable<Student> Students { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: api/Students
        [Route("api/Students/Get")]
        [HttpGet]

        public IEnumerable<Student> GetStudents()
        {
            Students = _studentRepository.GetStudentsAll();
            return  Students;
        }


        [Route("api/Students/GetById/{id}")]
        [HttpGet]
        public ActionResult<Student> GetStudent(int id)
        {
            Student = _studentRepository.GetStudentById(id);
            if (Student == null)
            {
                return NotFound();
            }
            return Student;
        }


        [Route("api/Students/Create")]
        [HttpPost]

        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            _studentRepository.AddStudent(student);
          
            _studentRepository.Commit();                    
         
            return CreatedAtAction(nameof(GetStudents), new { id = student.StudentId }, student);
        }
        //private bool StudentExists(int id)
        //{
        //    return _context.Students.Any(e => e.StudentId == id);
        //}
    }
}