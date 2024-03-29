﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTodo.Model
{
    public class StudentContext: DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options): base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        //public DbSet<Subject> Subjects { get; set; }
    }
}
