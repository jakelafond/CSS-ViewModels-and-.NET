using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using css_viewmodels_and_.net.Models;

namespace css_viewmodels_and_.net.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Article-1-heading"] = "Hire a Professional Handyman - Call 12345";
            return View();
        }
        public IActionResult PriceList()
        {
            ViewData["Message"] = "Prices here:";

            return View();
        }
        public IActionResult References()
        {
            ViewData["Message"] = "Look at all the people who like me:";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
