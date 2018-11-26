using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyTreePart2.Controllers
{
    public class FamilyTreeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}