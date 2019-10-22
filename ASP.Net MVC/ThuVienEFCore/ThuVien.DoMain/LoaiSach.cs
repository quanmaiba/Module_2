using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuVien.DoMain
{
    public class LoaiSach
    {
        [Key]
        public string MaLoaiSach { get; set; }
        public string TenLoai { get; set; }
        public List<Sach> Saches { get; set; }

    }
}
