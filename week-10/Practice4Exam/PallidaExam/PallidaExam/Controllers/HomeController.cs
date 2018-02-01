using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PallidaExam.Repositiries;

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
            return View(carRepository.GetCar(plateNumber,police,diplomat));
        }

        [HttpGet("search/{brand}")]
        public IActionResult FilterBrand([FromRoute]string brand)
        {
            return View("Index", carRepository.FilterBrand(brand));
        }
    }
}