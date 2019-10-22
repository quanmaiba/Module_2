using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVCStudent.Models
{
    public class Group
    {
        public int GroupId { get; set; }

        [Required, Display(Name = "Tên Nhóm")]
        [Column(TypeName = "nvarchar(50)")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string GroupName { get; set; }

        [Required, Display(Name = "Mô Tả")]
        public string Description { get; set; }

        [Display(Name = "Ngày Tạo")]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Range(typeof(DateTime), "1/2/1111", "3/4/2019",
        ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        //public DateTimeOffset? StartDate { get; set; }

        [Display(Name = "SL Học Sinh")]
        public IEnumerable<Student> Students { get; set; }

    }
}
