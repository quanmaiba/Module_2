using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models.Students
{
    public class GroupView
    {
        public int GroupId { get; set; }

        [Required, Display(Name = "Tên Nhóm")]    
        public string GroupName { get; set; }

        [Required, Display(Name = "Mô Tả")]
        public string Description { get; set; }

        [Display(Name = "Ngày Tạo")]
        public DateTime StartDate { get; set; }

        [Display(Name = "SL Học Sinh")]
        public IEnumerable<StudentView> Students { get; set; }
    }
}
