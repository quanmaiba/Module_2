using System.ComponentModel.DataAnnotations;

namespace BoDeTracNghiemDemo.Models
{
    public class DiemThi
    {
        public int DiemThiId { get; set; }

        [Required]
        public string TenDiemThi { get; set; }

        public int ThiId { get; set; }
        public Thi Thi { get; set; }
    }

}
