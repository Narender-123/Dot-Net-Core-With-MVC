using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IdentityFrameworkDemo.Models
{
    //This model is used for Collection the Data(User Email Address) From the User to Send the Email Containing the Token For Forgot Password
    public class ForgotPasswordModel
    {
        [Required,EmailAddress, Display(Name ="Enter the Registerd Email")]
        public string  Email { get; set; }

        //This Flag is used to Dispaly the Success message after the Successful Email is Sent
        public bool EmailSent { get; set; }
    }
}
