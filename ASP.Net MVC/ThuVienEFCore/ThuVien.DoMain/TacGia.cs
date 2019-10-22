using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuVien.DoMain
{
    public class TacGia
    {
        [Key]
        public string MaTacGia { get; set; }
        public string TenTacGia { get; set; }
        public string DiaChi { get; set; }
        public List<Sach> Saches { get; set; }

    }
}
