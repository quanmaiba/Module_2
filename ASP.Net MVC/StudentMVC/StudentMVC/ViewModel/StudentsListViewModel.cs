using StudentMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.ViewModel
{
    public class StudentsListViewModel
    {
        public IEnumerable<Student> Students { get; set; }
        public string CurrentGroup { get; set; }
        public Student Student { get; set; }
    }
}
