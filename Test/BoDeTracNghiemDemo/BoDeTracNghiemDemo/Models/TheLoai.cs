using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BoDeTracNghiemDemo.Models
{
    public class TheLoai
    {
        public int TheLoaiId { get; set; }

        [Required]
        public string TenTheLoai { get; set; }

        public IEnumerable<CauHoi> CauHois { get; set; }
    }

}
