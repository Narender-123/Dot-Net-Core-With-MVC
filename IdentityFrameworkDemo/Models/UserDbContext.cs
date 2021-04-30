using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityFrameworkDemo.Models
{
    //If we are using IdentityUser instead of Custom User then we have need to Define the User Also
    public class UserDbContext:IdentityDbContext<ApplicationUser>
    {
        public UserDbContext(DbContextOptions<UserDbContext> options):base(options)
        {

        }
    }
}
