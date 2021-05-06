using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityFrameworkDemo.Models;
using IdentityFrameworkDemo.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;


//To Save the Details we have need to Create a repository
namespace IdentityFrameworkDemo.Repository
{
    public class AccountRepository : IAccountRepository
    {
        //Here we have define the Fileds to Mange Our Entity
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        private readonly IConfiguration _configuration;

        //Here we have to Inject(Add) Dependencies bcoz we are using Identity Framework here So we are using the Classes that will handle the Details

        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            IUserService userService,
            IEmailService emailService,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
            _emailService = emailService;
            _configuration = configuration;
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

            //Code to Implement EmailConfirmation
            if (result.Succeeded)
            {
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                if (!string.IsNullOrEmpty(token)) 
                {
                    //Here we have to implement the code to send the Email with token to UserEmailId
                    await SendEmailConfirmationEmail(user, token);
                }
            }
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

        //Here we need the Logged in User So that we can Performed changes to a Specific user for that we get Id of Current LoggedIn User
        public async Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel model) 
        {
            var UserId = _userService.GetUserId();
            var User = await _userManager.FindByIdAsync(UserId);
            var result = await _userManager.ChangePasswordAsync(User, model.CurrentPassword, model.NewPassword);
            return result;
        }

        private async Task SendEmailConfirmationEmail(ApplicationUser user, string token)
        {
            string appDomain = _configuration.GetSection("Application:AppDomain").Value;
            string confirmationLink = _configuration.GetSection("Application:EmailConfirmation").Value;
            UserEmailOptionsModel Options = new UserEmailOptionsModel
            {
                ToEmails = new List<string>() { user.Email },
                Placeholders = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("{{UserName}}", user.FirstName),
                    new KeyValuePair<string, string>("{{link}}", string.Format(appDomain + confirmationLink,user.Id,token))
                }

            };
            await _emailService.SendEmailForEmailConfirmation(Options);
        }

    }
}
