using System.ComponentModel.DataAnnotations;

namespace GameLOL.WebData.Models
{
    public class quan
    {
        public int Id { get; set; }
        //public string Message { get; set; }
        [Required(ErrorMessage = "Name is Required")]

        public string Name { get; set; }
        public bool Avalible { get; set; }
        public decimal Price { get; set; }
        public decimal? Khuyenmai { get; set; }
    }
}
