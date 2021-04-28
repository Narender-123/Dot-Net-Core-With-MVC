using IdentityFrameworkDemo.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace IdentityFrameworkDemo.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateAsyncUser(SignUpModel userModel);
    }
}