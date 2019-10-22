using System.ComponentModel.DataAnnotations;

namespace BoDeTracNghiemDemo.Models
{
    public class CauHoiThi
    {
        public int CauHoiId { get; set; }

        [Required]
        public CauHoi CauHoi { get; set; }

        public int ThiId { get; set; }
        public Thi Thi { get; set; }
    }

}
