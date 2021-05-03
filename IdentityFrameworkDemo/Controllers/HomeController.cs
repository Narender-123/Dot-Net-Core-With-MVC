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

        public HomeController(ILogger<HomeController> logger,IUserService userService)
        {
            _userService = userService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var UserId = _userService.GetUserId();
            var IsLoggedIn = _userService.IsAuthenticated();
            ViewData["UserId"] = UserId;
            ViewData["IsLoggedIn"] = IsLoggedIn;
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
