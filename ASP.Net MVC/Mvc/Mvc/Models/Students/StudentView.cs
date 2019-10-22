using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models.Students
{
    public class StudentView
    {
        public int StudentId { get; set; }

        [Required, Display(Name = "Tên Học Sinh")]      
        public string Name { get; set; }

        [Display(Name = "Ảnh")]
        public string UrlImage { get; set; }

        [Display(Name = "Tiểu Sử")]
        public string History { get; set; }

        [Required, Display(Name = "Giới Tính")]
        public bool Sex { get; set; }

        [Display(Name = "Nhóm")]
        public int GroupId { get; set; }
    }
}
