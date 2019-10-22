using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCStudent.Models;
using System.Collections.Generic;

namespace MVCStudent.ViewModel
{
    public class StudentsEditViewModel : StudentsListViewModel
    {
        public int Id { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public string CurrentGroup { get; set; }

        public SelectList Groups { get; set; }
        public bool Sex { get; set; }
        public string Name { get; set; }
        public string History { get; set; }

        public int GroupId { get; set; }
        public string ExistingPhotoPath { get; set; }
        public List<IFormFile> Photos { get; set; }
    }
}
