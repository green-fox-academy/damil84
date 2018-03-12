using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;
using BankOfSimba.ViewModels;

namespace BankOfSimba.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        static AccountsViewModel accounts = new AccountsViewModel();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Simba")]
        public IActionResult Simba()
        {
            BankAccount account = new BankAccount("Simba", 2000.00, "zebra", "Lion", true);

            return View();
        }

        [HttpGet("Accounts")]
        public IActionResult Accounts()
        {
            return View(accounts);
        }

        [HttpGet("About")]
        public IActionResult About()
        {
            ViewData["Message"] = "This is Bank of Simba's About page, which is about About.";

            return View();
        }

        [HttpPost("Add")]
        public IActionResult AddAcount(BankAccount bankAccount)
        {
            accounts.AccountList.Add(bankAccount);
            return RedirectToAction("Accounts");
        }

        [HttpPost("RaiseCurrency")]
        public IActionResult RaiseCurrency(string name)
        {
            foreach (var animal in accounts.AccountList)
            {
                if (animal.Name == name)
                {
                    if(animal.Status == "KING")
                    {
                        animal.Balance += 100;
                    }
                    else
                    {
                            animal.Balance += 10;
                    }
                }
                else
                {
                   
                }
            }


            return RedirectToAction("Accounts");
        }

        [HttpPost("RaiseCurrencyName")]
        public IActionResult RaiseCurrencyName()
        {
            return RedirectToAction("Accounts");
        }
    }
}