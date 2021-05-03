using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;



//This Class Contains the CommonCode(Service) which we are inject anywhere in the Application to get the UserId

namespace IdentityFrameworkDemo.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        //Here we inject the Service which access the HttpContext
        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }


        //This Method will return the Id of Loggedin User
        public string GetUserId()
        {
            return _httpContextAccessor.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        //This method is Used to check Wheather the User is Logged in or not
        public bool IsAuthenticated() 
        {
            return _httpContextAccessor.HttpContext.User.Identity.IsAuthenticated;
        }
    }
}
