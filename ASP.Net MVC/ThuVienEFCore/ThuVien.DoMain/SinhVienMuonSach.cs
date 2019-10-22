using System;
using System.ComponentModel.DataAnnotations;

namespace ThuVien.DoMain
{
    public class SinhVienMuonSach
    {

        public Sach Sach { get; set; }
        public string MaSach { get; set; }
        public SinhVien SinhVien { get; set; }
        public string MaSv { get; set; }
        public int SoNgayMuon { get; set; }
        public string HinhThucMuon { get; set; }
        public DateTime NgayTra { get; set; }
        public DateTime NgayMuon { get; set; }
    }
}
