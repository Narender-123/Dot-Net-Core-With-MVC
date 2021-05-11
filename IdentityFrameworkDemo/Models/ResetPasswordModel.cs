using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityFrameworkDemo.Models
{
    //This model is Used for getting the New Password 
    public class ResetPasswordModel
    {
        [Required(ErrorMessage="Enter Name")]
        public string  UserId { get; set; }

        [Required]
        public string Token { get; set; }

        [Required, DataType(DataType.Password)]
        public string  NewPassword { get; set; }

        [Required,DataType(DataType.Password)]
        [Compare("NewPassword",ErrorMessage ="Both the Password Dont match")]
        public string ConfirmPassword { get; set; }

        public bool IsSuccess { get; set; }

    }
}
