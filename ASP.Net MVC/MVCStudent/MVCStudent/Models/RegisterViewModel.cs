using Microsoft.AspNetCore.Mvc;
using MVCStudent.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCStudent.Models
{
    public class RegisterViewModel
    {
        public int Id { get; set; }

        [Required,EmailAddress]
        [Remote(action: "IsEmailInUse",controller:"Account")]
        [ValidEmailDomain(allowedDomain:"anhquan.com")]
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
