namespace BoDeTracNghiemDemo.Models
{
    public class CauHoiThi
    {
        public int CauHoiId { get; set; }

        public CauHoi CauHoi { get; set; }

        public int ThiId { get; set; }
        public Thi Thi { get; set; }
    }

}
