using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetPractice.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetPractice.Controllers
{
    [Route("")]
    [Route("Home")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("")]
        [Route("index")]
        [Route("index/{ id}")]
        public IActionResult Index(int id)
        {
            Contact contact = new Contact()
            {
                FirstName = "Johnny",
                LastName = "Bravo",
                Id = id
            };
        
            return View(contact);
        }
    }
}
