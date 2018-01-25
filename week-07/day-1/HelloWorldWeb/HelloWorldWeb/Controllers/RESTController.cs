using Microsoft.AspNetCore.Mvc;
using HelloWorldWeb.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorldWeb.Controllers
{
    [Route("")]
    [Route("api")]
    public class RESTController : Controller
    {
        public static int userCounter { get; set; } = 0;
        // GET: /<controller>/
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return Content("API index, Hello!");
        }

        [Route("Greeting")]
        [Route("Greeting/{name}")]
        public IActionResult Greeting([FromQuery]string name)
        {
            userCounter++;
            var hello = new Greeting(name, userCounter);
            return new JsonResult(hello);
        }
    }
}
