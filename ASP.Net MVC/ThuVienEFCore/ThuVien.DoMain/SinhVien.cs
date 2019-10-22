using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuVien.DoMain
{
    public class SinhVien
    {
        [Key]
        public string MaSv { get; set; }
        public string Lop { get; set; }
        public string HoTen { get; set; }
        public List<SinhVienMuonSach> SinhVienMuonSaches { get; set; }
        public TheSinhVien TheSinhVien { get; set; }
    }
}
