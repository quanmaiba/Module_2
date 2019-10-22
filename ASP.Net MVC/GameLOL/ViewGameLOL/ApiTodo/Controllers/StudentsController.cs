using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiTodo.Model;

namespace ApiTodo.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentContext _context;

        public StudentsController(StudentContext context)
        {
            _context = context;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: api/Students
        [Route("api/Students/Get")]
        [HttpGet]
       
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Students/5
        [Route("api/Students/GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>

        //[Route("api/Students/Update")]
        //[HttpPut]
        //public int PutStudent(Student student)
        //{
        //    int id = student.Id;
        //    if (id == 0)
        //    {
        //        return 0;
        //    }
        //    _context.Entry(student).State = EntityState.Modified;

        //    try
        //    {
        //        _context.SaveChanges();
        //        return id;
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        return 0;
        //    }
        //}

        [Route("api/Students/Update")]
        [HttpPut]
        public async Task<IActionResult> PutStudent(Student student)
        {
            int id = student.Id;
            if (id != student.Id)
            {
                return BadRequest();
            }

            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        // POST: api/Students
        [Route("api/Students/Create")]
        [HttpPost]
        
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetStudents), new { id = student.Id }, student);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE: api/Students/5
        [Route("api/Students/Delete/{id}")]
        [HttpDelete]
        public async Task<ActionResult<bool>> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            try
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            } 
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}
