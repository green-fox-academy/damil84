using Microsoft.AspNetCore.Mvc;
using WebGreetCounter.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebGreetCounter.Controllers
{
    [Route("")]
    [Route("api")]
    public class RESTController : Controller
    {
        public static int UserCounter { get; set; } = 0;
        // GET: /<controller>/
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return Content("API index, Hello!");
        }

        [Route("Greeting")]
        public IActionResult Greeting([FromQuery]string name)
        {
            UserCounter++;
            var hello = new Greeting(name, UserCounter);
            return new JsonResult(hello);
        }
    }
}