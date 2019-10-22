using System.ComponentModel.DataAnnotations;

namespace MVCStudent.ViewModel
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
