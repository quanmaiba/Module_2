using BoDeTracNghiemDemo.Utilities;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BoDeTracNghiemDemo.ViewModel
{
    public class RegisterViewModel
    {
        [Required, EmailAddress]
        [Remote(action: "IsEmailInUse", controller: "Account")]
        [ValidEmailDomain(allowedDomain: "anhquan.com", ErrorMessage = "Email domain must be anhquan.com")]
        public string Email { get; set; }


        [Required, DataType(DataType.Password)]
        public string Password { get; set; }


        [Required, DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password an ConfirmPassword do not match.")]
        public string ConfirmPassword { get; set; }

        public string City { get; set; }
    }
}
