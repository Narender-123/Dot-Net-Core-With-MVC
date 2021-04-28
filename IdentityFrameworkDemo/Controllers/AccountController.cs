﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityFrameworkDemo.Models;
using IdentityFrameworkDemo.Repository;

namespace IdentityFrameworkDemo.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;

        //Here We Inject the AccountRepository so that we can make use all the features of that object 
        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [Route("signup")]
        public IActionResult SignUp()
        {
            return View();
        }

        [Route("signup")]
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel signUpModel) 
        {
            //If ModelState is Valid That means to Store in the Database
            if (ModelState.IsValid)
            {
                //Write Your Code
                //Below Code Will Invoke the Method which define the Logic to Add UserDetails
                var result = await _accountRepository.CreateAsyncUser(signUpModel);

                //Now we have to check for the Success
                if (!result.Succeeded) 
                {
                    foreach (var errorMessage in result.Errors) 
                    {
                        ModelState.AddModelError("",errorMessage.Description);
                    }
                    return View(signUpModel);
                }

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
