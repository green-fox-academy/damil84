using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetCounterREST.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet("index")]
        public IActionResult Index()
        {
            return Content("Hello HomeIndex");
        }

        [HttpGet("hello")]
        public IActionResult Hello()
        {
            return Content("Hello-bello, dear world!");
        }
    }
}