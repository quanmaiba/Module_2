using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCStudent.Models;
using System.Collections.Generic;

namespace MVCStudent.ViewModel
{
    public class StudentsListViewModel
    {
        public IEnumerable<Student> Students { get; set; }
        public string CurrentGroup { get; set; }
        public Student Student { get; set; }
        public SelectList Groups { get; set; }
        public string Name { get; set; }
        public string History { get; set; }
        public string ExistingPhotoPath { get; set; }
        public IFormFile Photos { get; set; }
    }
}
