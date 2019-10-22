using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentMVC.Models
{
    public class Group
    {
        public int GroupId { get; set; }

        [Required, Display(Name = "Tên Nhóm")]
        [Column(TypeName = "nvarchar(50)")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string GroupName { get; set; }

        [Required, Display(Name = "Mô Tả")]
        public string Description { get; set; }

        [Display(Name = "Ngày Tạo")]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        //public DateTimeOffset? StartDate { get; set; }

        [Display(Name = "SL Học Sinh")]
        public IEnumerable<Student> Students { get; set; }     
    }
}
