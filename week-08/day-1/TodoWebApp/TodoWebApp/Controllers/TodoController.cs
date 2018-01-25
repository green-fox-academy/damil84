using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoWebApp.Controllers
{
    [Route("todo")]
    public class Todo : Controller
    {
        // GET: /<controller>/
        [Route("")]
        [Route("{id}")]
        public IActionResult Index([FromRoute] int id)
        {
            return Json(new { Id = id } + "shithead");
        }

        [Route("list")]
        public IActionResult List()
        {
            return Content("This is my first todo string");
        }

        [HttpGet("test")]
        public IActionResult GetView()
        {
            return View();
        }
    }
}