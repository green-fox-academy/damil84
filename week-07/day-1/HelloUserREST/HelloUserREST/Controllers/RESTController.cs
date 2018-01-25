using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorldREST.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorldREST.Controllers
{
    [Route("")]
    [Route("api")]
    public class RESTController : Controller
    {
        // GET: /<controller>/
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return Content("API index, Hello!");
        }

        [Route("")]
        [Route("Greeting")]
        public IActionResult Greeting([FromQuery]string name)
        {
            var greeting = new Greeting(1,name);
            return new JsonResult(greeting);
        }
    }
}
