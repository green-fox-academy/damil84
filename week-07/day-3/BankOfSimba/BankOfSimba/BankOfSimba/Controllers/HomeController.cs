using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;
using BankOfSimba.ViewModels;

namespace BankOfSimba.Controllers
{   
    [Route("")]
    public class HomeController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Simba")]
        public IActionResult Simba()
        {
            BankAccount account = new BankAccount("Simba", 2000.00, "zebra", "Lion");

            return View(account);
        }

        [HttpGet("Accounts")]
        public IActionResult Accounts()
        {
            AccountsViewModel accounts = new AccountsViewModel();
            return View(accounts);
        }
    }
}