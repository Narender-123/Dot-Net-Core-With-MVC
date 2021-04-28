using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityFrameworkDemo.Models;

namespace IdentityFrameworkDemo.Controllers
{
    public class AccountController : Controller
    {
        [Route("signup")]
        public IActionResult SignUp()
        {
            return View();
        }

        [Route("signup")]
        [HttpPost]
        public IActionResult SignUp(SignUpModel signUpModel) 
        {
            //If ModelState is Valid That means to Store in the Database
            if (ModelState.IsValid)
            {
                //Write Your Code
                ModelState.Clear();
                return View();
            }
            return View(signUpModel);
        }

        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
