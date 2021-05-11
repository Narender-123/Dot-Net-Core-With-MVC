using IdentityFrameworkDemo.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace IdentityFrameworkDemo.Repository
{
    //Here We Define the Mandatory Methods For the Sepecific Opeartions
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateAsyncUser(SignUpModel userModel);

        Task GenerateEmailConfirmationTokenAsync(ApplicationUser user);
        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);

        Task SignOutAsync();

        Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel model);

        Task<IdentityResult> ConfirmEmailAsync(string uid, string token);

        Task<ApplicationUser> GetUserByEmailAsync(string email);

        Task GenerateForgotPasswordTokenAsync(ApplicationUser user);
        Task<IdentityResult> ResetPasswordAsync(ResetPasswordModel model);



    }
}