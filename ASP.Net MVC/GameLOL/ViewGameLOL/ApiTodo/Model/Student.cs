using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTodo.Model
{
    public class Student
    {
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Address { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string PhoneNumber { get; set; }
        //public List<Subject> Subjects { get; set; }

    }
}
