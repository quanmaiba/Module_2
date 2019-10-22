using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPage.Model
{
    public partial class QuanLySach
    {
        [Key]
        public int Id { get; set; }
        [Required,Display(Name ="Tên Sách")]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(maximumLength: 50, MinimumLength = 1)]
        public string TenSach { get; set; }

        [Required, Display(Name = "Tên Tác Giả")]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(maximumLength: 50, MinimumLength = 1)]
        public string TenTacGia { get; set; }

        [ Display(Name = "Mô Tả")]        
        public string MoTa { get; set; }

        [Required, Display(Name = "Năm Sản Xuất")]    
        [Range(maximum:2019,minimum:1)]
        public int NamSanXuat { get; set; }

        [Required, Display(Name = "Số Lượng")]
        [Range(maximum: 1000000, minimum: 1)]
        public int SoLuong { get; set; }
        [Display(Name = "Thể Loại")]
        public TheLoai TheLoais { get; set; }

    }
}
