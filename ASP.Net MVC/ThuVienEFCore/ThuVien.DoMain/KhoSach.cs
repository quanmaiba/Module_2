using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuVien.DoMain
{
    public class KhoSach
    {
        [Key]
        public string MaKho { get; set; }
        public List<Sach> Saches { get; set; }
        [DataType(DataType.Date)]
        public string TenKho { get; set; }
    }
}
