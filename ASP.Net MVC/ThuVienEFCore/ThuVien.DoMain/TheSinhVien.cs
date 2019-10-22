using System;
using System.ComponentModel.DataAnnotations;

namespace ThuVien.DoMain
{
    public class TheSinhVien
    {
        [Key]
        public string MaThe { get; set; }
        public string TenSinhVien { get; set; }
        public DateTime NgayHetHan { get; set; }

        public string MaSv { get; set; }

    }
}
