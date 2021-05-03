using IdentityFrameworkDemo.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace IdentityFrameworkDemo.Repository
{
    //Here We Define the Mandatory Methods For the Sepecific Opeartions
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateAsyncUser(SignUpModel userModel);
        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);

        Task SignOutAsync();

        Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel model);
    }
}