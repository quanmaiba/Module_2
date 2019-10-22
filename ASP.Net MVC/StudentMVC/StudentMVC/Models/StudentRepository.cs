﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace StudentMVC.Models
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MvcContext context;

        public IEnumerable<Student> GetStudentsAll => context.Students.ToList();

        public StudentRepository(MvcContext context)
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

        //public IEnumerable<Student> GetStudentsAll()
        //{
        //    return context.Students.ToList();
        //}

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

    }
}