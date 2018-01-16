using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetPractice.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetPractice.Controllers
{
    [Route("[controller]")]
    public class MembersHomeController : Controller
    {
        // GET: /<controller>/
        [Route("")]
        [Route("[action]")]
        public IActionResult Index(int id)
        {
            Contact contact = new Contact()
            {
                Id = id
            };
            return View(contact);
        }
        [Route("access")]
        public  IActionResult AccessGranted()
        {
            return View();
        }
    }
}
