using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PallidaExam.Repositiries;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PallidaExam.Controllers
{
    [Route("Api")]
    public class RESTController : Controller
    {
        private CarsRepository carRepository;

        public RESTController(CarsRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        [HttpGet("search/{brand}")]
        public IActionResult FilterBrand([FromRoute]string brand)
        {
            return View();
        }
    }
}
