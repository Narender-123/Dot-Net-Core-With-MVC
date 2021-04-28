using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityFrameworkDemo.Models;
using Microsoft.AspNetCore.Identity;


//To Save the Details we have need to Create a repository
namespace IdentityFrameworkDemo.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<IdentityUser> _userManager;

        //Here we have to Inject(Add) Dependencies bcoz we are using Identity Framework here So we are using the Classes that will handle the Details

        public AccountRepository(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IdentityResult> CreateAsyncUser(SignUpModel userModel)
        {
            //Here We Create IdentityUser
            var user = new IdentityUser()
            {
                Email = userModel.Email,
                UserName = userModel.Email,
            };
            var result = await _userManager.CreateAsync(user, userModel.Password);
            return result;
        }
    }
}
