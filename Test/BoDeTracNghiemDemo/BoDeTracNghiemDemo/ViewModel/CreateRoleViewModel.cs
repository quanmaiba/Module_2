using System.ComponentModel.DataAnnotations;

namespace BoDeTracNghiemDemo.ViewModel
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }


}
