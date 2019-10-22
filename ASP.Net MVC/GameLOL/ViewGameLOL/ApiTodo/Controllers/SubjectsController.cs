//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using ApiTodo.Model;

//namespace ApiTodo.Controllers
//{
   
//    [ApiController]
//    public class SubjectsController : ControllerBase
//    {
//        private readonly StudentContext _context;

//        public SubjectsController(StudentContext context)
//        {
//            _context = context;
//        }

//        // GET: api/Subjects
//        [Route("api/Subjects/Get")]
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Subject>>> GetSubjects()
//        {
//            return await _context.Subjects.ToListAsync();
//        }

//        // GET: api/Subjects/5
//        [Route("api/Subjects/Get/{id}")]
//        [HttpGet]
//        public async Task<ActionResult<Subject>> GetSubject(int id)
//        {
//            var subject = await _context.Subjects.FindAsync(id);

//            if (subject == null)
//            {
//                return NotFound();
//            }

//            return subject;
//        }

//        // PUT: api/Subjects/5
//        [Route("api/Students/Update")]
//        [HttpPut]
       
//        public async Task<ActionResult<int>> PutSubject(Subject subject)
//        {


//            int id = subject.Id;
//            if (id == 0)
//            {
//                return 0;
//            }
//            _context.Entry(subject).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//                return id;
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                return 0;
//            }
//        }

//        // POST: api/Subjects
//        [Route("api/Subjects/Create")]
//        [HttpPost]
//        public async Task<ActionResult<Subject>> PostSubject(Subject subject)
//        {
//            _context.Subjects.Add(subject);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetSubject", new { id = subject.Id }, subject);
//        }

//        // DELETE: api/Subjects/5
//        [Route("api/Subjects/Delete/{id}")]
//        [HttpDelete("{id}")]
//        public async Task<ActionResult<bool>> DeleteStudent(int id)
//        {
//            var subjects = await _context.Subjects.FindAsync(id);
//            if (subjects == null)
//            {
//                return NotFound();
//            }
//            try
//            {
//                _context.Subjects.Remove(subjects);
//                await _context.SaveChangesAsync();
//                return true;
//            }
//            catch
//            {
//                return false;
//            }
//        }
//        //public async Task<ActionResult<Subject>> DeleteSubject(int id)
//        //{
//        //    var subject = await _context.Subjects.FindAsync(id);
//        //    if (subject == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    _context.Subjects.Remove(subject);
//        //    await _context.SaveChangesAsync();

//        //    return subject;
//        //}

//        private bool SubjectExists(int id)
//        {
//            return _context.Subjects.Any(e => e.Id == id);
//        }
//    }
//}
