using IdentityFrameworkDemo.Models;
using IdentityFrameworkDemo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityFrameworkDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;

        public HomeController(ILogger<HomeController> logger,IUserService userService,
            IEmailService emailService)
        {
            _userService = userService;
            _emailService = emailService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var UserId = _userService.GetUserId();
            //var IsLoggedIn = _userService.IsAuthenticated();
            //ViewData["UserId"] = UserId;
            //ViewData["IsLoggedIn"] = IsLoggedIn;

            UserEmailOptionsModel options = new UserEmailOptionsModel
            {
                ToEmails = new List<string>
                {
                    "narenderkumar2121@gmail.com",
                    "17cs1008@mvn.edu.in"
                }
            };
            _emailService.SendTestEmail(options);
            return View();
        }

        //Here we can Apply the Authorisation attribute to restrict the Unauthroized user
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Demo1()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
