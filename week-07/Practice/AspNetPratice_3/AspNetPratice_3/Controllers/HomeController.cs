using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo_Week_08.Models;

namespace Demo_Week_08.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Monday()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is my About page, which is about About.";

            return View();
        }

        public IActionResult Tuesday()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Wednesday()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Thursday()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Friday()
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
