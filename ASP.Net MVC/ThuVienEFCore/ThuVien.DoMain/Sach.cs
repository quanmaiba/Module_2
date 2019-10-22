using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuVien.DoMain
{
    public class Sach
    {
        [Key]
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string MaNXB { get; set; }
        public int SoLuong { get; set; }
        public string MaTacGia { get; set; }
        public string MaViTri { get; set; }
        public string MaLoaiSach { get; set; }
        public string MaNgonNgu { get; set; }
        public string MaKho { get; set; }
        public NhaXuatBan NhaXuatBan { get; set; }
        public DateTime NamXuatBan { get; set; }

        public List<SinhVienMuonSach> SinhVienMuonSaches { get; set; }
    }
}
