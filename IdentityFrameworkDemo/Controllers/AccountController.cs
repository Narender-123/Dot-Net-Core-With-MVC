﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityFrameworkDemo.Controllers
{
    public class AccountController : Controller
    {
        [Route("signup")]
        public IActionResult SignUp()
        {
            return View();
        }

        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
