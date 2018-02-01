using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PallidaExam.Repositiries;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PallidaExam.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private CarsRepository carRepository;

        public HomeController(CarsRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        [HttpGet("search")]
        public IActionResult Index([FromQuery]string plateNumber, string police, string diplomat)
        {
            if (plateNumber != null && police == null && diplomat == null)
                return View(carRepository.FilterPlates(plateNumber));
            return View(carRepository.GetCar());
        }








        [HttpGet("search/{brand}")]
        public IActionResult FilterBrand()
        {
            return Ok();
        }
    }
}
