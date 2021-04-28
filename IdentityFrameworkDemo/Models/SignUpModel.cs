using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IdentityFrameworkDemo.Models
{
    //Here we designed Model For the Registartion/SignUp Page
    public class SignUpModel
    {
        [Required(ErrorMessage ="Plz Enter the Email")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Plz Enter the Valid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Plz Enter the Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Plz Provide the Same Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Plz ReEnter the Password ")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
