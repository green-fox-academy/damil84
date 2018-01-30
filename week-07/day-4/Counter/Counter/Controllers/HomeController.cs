using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Counter.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Counter.Controllers
{   
    [Route("")]
    public class HomeController : Controller
    {
        private CounterModel counter;

        public HomeController(CounterModel counter)
        {
            this.counter = counter;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(counter);
        }

        [HttpPost("")]
        public IActionResult PostMethod()
        {
            this.counter.counter++;
            return RedirectToAction("Index");
        }
    }
}
