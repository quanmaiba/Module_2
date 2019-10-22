using System.ComponentModel.DataAnnotations;

namespace BoDeTracNghiemDemo.Models
{
    public class DapAn
    {
        public int DapAnId { get; set; }

        [Required]
        public string TenDapAn { get; set; }


        public int CauHoiId { get; set; }
        public CauHoi CauHoi { get; set; }
    }

}
