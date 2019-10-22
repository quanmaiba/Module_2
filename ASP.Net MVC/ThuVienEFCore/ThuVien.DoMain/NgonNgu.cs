using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuVien.DoMain
{
    public class NgonNgu
    {
        [Key]
        public string MaNgonNgu { get; set; }
        public string TenNgonNgu { get; set; }
        public List<Sach> Saches { get; set; }
    }
}
