using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BoDeTracNghiemDemo.Models
{
    public class CauHoi
    {
        public int CauHoiId { get; set; }

        [Required]
        public string TenCauHoi { get; set; }

        [Required]
        public string CauTraLoi1 { get; set; }

        [Required]
        public string CauTraLoi2 { get; set; }

        [Required]
        public string CauTraLoi3 { get; set; }

        [Required]
        public string CauTraLoi4 { get; set; }

        public int TheLoaiId { get; set; }
        public TheLoai TheLoai { get; set; }



        public DapAn DapAn { get; set; }

        public IEnumerable<CauHoiThi> CauHoiThis { get; set; }
    }

}
