using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursosCrudRazor.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required,Display(Name = " Name Student")]
        public string Name { get; set; }
        [Required, Display(Name = "Address Student")]
        public string Address { get; set; }
        public Skill Skill { get; set; }
    }
}
