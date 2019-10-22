using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BoDeTracNghiemDemo.Models
{
    public class Thi
    {
        public int ThiId { get; set; }

        [Required]
        public string TenThi { get; set; }

        public DiemThi DiemThi { get; set; }


        public int NguoiDungId { get; set; }
        public NguoiDung NguoiDung { get; set; }

        public IEnumerable<CauHoiThi> CauHoiThis { get; set; }
    }

}
