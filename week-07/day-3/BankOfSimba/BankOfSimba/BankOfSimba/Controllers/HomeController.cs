using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

namespace BankOfSimba.Controllers
{   
    [Route("")]
    public class HomeController : Controller
    {
        //// GET: /<controller>/
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("simba")]
        [HttpGet("Simba")]
        public IActionResult Simba()
        {
            BankAccount account = new BankAccount("Simba", 2000, "Lion");

            return View(account);
        }
    }
}