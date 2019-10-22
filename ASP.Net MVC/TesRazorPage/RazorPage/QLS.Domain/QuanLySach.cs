using System;

namespace QLS.Domain
{
    public class QuanLySach
    {
        public int Id { get; set; }
        public string TenSach { get; set; }
        public string TenTacGia { get; set; }
        public string MoTa { get; set; }
        public DateTime NamSanXuat { get; set; }
        public int SoLuong { get; set; }
        public TheLoai TheLoais { get; set; }

    }
}
