using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyTreePart2.Models.Account;

namespace MyTreePart2.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            User user = new User
            {
                FirstName = "Karl",
                LastName = "Erik",
                Email = "KarlErikDenAnden@gmail.com"
            };
            return View(user);
        }
    }
}