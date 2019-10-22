using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuVien.DoMain
{
    public class NhaXuatBan
    {
        [Key]
        public string MaNXB { get; set; }
        public string TenNXB { get; set; }
        public string DiaChi { get; set; }
        public IEnumerable<Sach> Saches { get; set; }
    }
}
