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
        //Here we have define the Fileds to Mange Our Entity
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        //Here we have to Inject(Add) Dependencies bcoz we are using Identity Framework here So we are using the Classes that will handle the Details

        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IdentityResult> CreateAsyncUser(SignUpModel userModel)
        {
            //Here We Create IdentityUser(=>Application User if we are adding Custom Properties to the Identity Class)
            var user = new ApplicationUser()
            {
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                DateOfBirth = userModel.DateOfBirth,
                Email = userModel.Email,
                UserName = userModel.Email,
            };
            var result = await _userManager.CreateAsync(user, userModel.Password);
            return result;
        }

        public async Task<SignInResult> PasswordSignInAsync(SignInModel signInModel) 
        {
            var result = await _signInManager.PasswordSignInAsync(signInModel.Email, signInModel.Password,signInModel.RememberMe, false);
            return result;
        }

        //Here we define the Method For the Logout
        public async Task SignOutAsync() 
        {
            await _signInManager.SignOutAsync();
        }
    }
}
