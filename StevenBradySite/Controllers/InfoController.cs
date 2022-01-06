using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StevenBradySite.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Info()
        {
            return View();
        }

        public IActionResult ImportantLocationsAndLinks()
        {
            return View();
        }

        public IActionResult SignificantPeople()
        {
            return View();
        }
    }
}
