using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Model
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext context;

        public StudentRepository(AppDbContext context)
        {
            this.context = context;
        }

        public bool Commit()
        {
            try
            {
                context.SaveChanges();
                return false;
            }
            catch
            {
                return true;
            }
        }

        public Student DeleteStudent(int id)
        {
            var student = GetStudentById(id);
            if (student != null)
            {
                context.Students.Remove(student);
            }

            return student;
        }

        public Student GetStudentById(int id)
        {
            var student = context.Students.Find(id);
            return student;
        }

        public IEnumerable<Student> GetStudentsAll()
        {
            return context.Students.ToList();
        }

        public Student AddStudent(Student student)
        {
            context.Students.Add(student);

            return student;
        }

        public Student UpdateStudent(Student student)
        {
            var entity = context.Students.Attach(student);
            entity.State = EntityState.Modified;

            return student;
        }

        //public async Task<bool> Commit()
        //{
        //    try
        //    {
        //       await context.SaveChangesAsync();
        //        return false;
        //    }
        //    catch
        //    {
        //        return true;
        //    }
        //}

        //public async Task<ActionResult<Student>> DeleteStudent(int id)
        //{
        //    var student = await context.Students.FindAsync(id);
        //    if (student != null)
        //    {
        //        context.Students.Remove(student);
        //    }

        //    return student;
        //}

        //public async Task<ActionResult<Student>> GetStudentById(int id)
        //{
        //    var student = await context.Students.FindAsync(id);
        //   return student;
        //}

        //public async Task<ActionResult<IEnumerable<Student>>> GetStudentsAll()
        //{
        //    return await context.Students.ToListAsync();
        //    //Sreturn await context.Students.Include(g => g.Group);
        //}

        //public async Task<ActionResult<Student>> PostStudent(Student student)
        //{
        //    context.Students.Add(student);
        //    return student;
        //}

        //public async Task<ActionResult<Student>> PutStudent(int id, Student student)
        //{

        //}
    }

}
