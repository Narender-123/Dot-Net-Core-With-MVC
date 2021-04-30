using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace IdentityFrameworkDemo.Models
{
    //We Use this Class to Add All the Additional Fields of our SignUp Page
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth  { get; set; }

    }
}
