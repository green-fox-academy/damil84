using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloUserRest.Controllers
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
