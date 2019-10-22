using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BoDeTracNghiemDemo.Models
{
    public class NguoiDung
    {
        public int NguoiDungId { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string MatKau { get; set; }

        [Required]
        public string XacNhanMatKhau { get; set; }

        [Required]
        public string DiaChi { get; set; }

        public string PhotoPath { get; set; }

        public IEnumerable<Thi> This { get; set; }

    }
}
