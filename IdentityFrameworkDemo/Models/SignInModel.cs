using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityFrameworkDemo.Models
{
    public class SignInModel
    {
        [Required(ErrorMessage ="Plz Enter Email"),EmailAddress]
        public String Email { get; set; }
        [Required(ErrorMessage = "Plz Enter Email")]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        
        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
