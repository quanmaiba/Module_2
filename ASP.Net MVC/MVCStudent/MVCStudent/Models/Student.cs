using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCStudent.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required, Display(Name = "Tên Học Sinh")]
        [DataType(DataType.Text)]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Display(Name = "Ảnh")]
        //[DataType(DataType.Url)]
        public string UrlImage { get; set; }

        [Display(Name = "Tiểu Sử")]
        //[CustomDateAttribute]
        //[DataType(DataType.Date)]
        public string History { get; set; }

        [Required, Display(Name = "Giới Tính")]
        public bool Sex { get; set; }

        public bool IsPlatinum { get; set; }



        [Display(Name = "Nhóm")]
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }

    public class CustomDateAttribute : RangeAttribute
    {
        public CustomDateAttribute() : base(typeof(DateTime),
            "1/1/1000",
            DateTime.Now.ToShortDateString())
        { }
    }
}
