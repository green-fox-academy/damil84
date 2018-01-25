using Microsoft.AspNetCore.Mvc;

namespace SayHelloToAll.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return Content("Hello HomeIndex");
        }

        [Route("hello")]
        public IActionResult Hello()
        {
            return Content("Hello-bello, dear world!");
        }
    }
}