using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IdentityFrameworkDemo.Models
{
    public class ChangePasswordModel
    {
        [Required(ErrorMessage ="Plz Enter Current Password"),DataType(DataType.Password), Display(Name ="Current Password")]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "Plz Enter New Password"), DataType(DataType.Password), Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Plz Enter Confirm Password"), DataType(DataType.Password), Display(Name = "Confirm New Password")]
        [Compare("NewPassword", ErrorMessage ="Plz Enter the Same Password For Both Fields")]
        public string ConfirmPassword { get; set; }

    }
}
