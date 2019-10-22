using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuVien.DoMain
{
    public class ViTri
    {
        [Key]
        public string MaViTri { get; set; }
        public string Khu { get; set; }
        public string Ke { get; set; }
        public string Ngan { get; set; }
        public List<Sach> Saches { get; set; }
    }
}
