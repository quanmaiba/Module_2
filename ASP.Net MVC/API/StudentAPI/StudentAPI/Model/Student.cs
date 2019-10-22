using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Model
{
    public class Student
    {
        public int StudentId { get; set; }

        //[Required,Display(Name = "Tên Học Sinh")]
        [Column(TypeName ="nvarchar(50)")]
        public string Name { get; set; }

        //[Display(Name = "Ảnh")]      
        public string UrlImage { get; set; }

        //[Display(Name = "Tiểu Sử")]
        public string History { get; set; }

        //[Required,Display(Name = "Giới Tính")]
        public bool Sex { get; set; }

        //[Display(Name = "Nhóm")]
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
