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
        public IActionResult Index([FromQuery]string platenumber)
        {
            return View(carRepository.GetCar());
        }






        //public IActionResult Index([FromQuery]string platenumber, string police, string diplomat)
        //{
        //    if (platenumber != null && police == null && diplomat == null)
        //        return View(carRepository.FilterPlates(platenumber));
        //    //else if (platenumber == null && police == null && diplomat == null)
        //    //    return View(carRepository.GetCar());
        //    else if (police != null && platenumber == null && diplomat == null)
        //        return View(carRepository.GetPolice());
        //    else if (diplomat != null && platenumber == null && police == null)
        //        return View(carRepository.GetDiplomat());
        //    else
        //        return View(carRepository.GetCar());

        //}

        [HttpGet("search/{brand}")]
        public IActionResult FilterBrand()
        {
            return Ok();
        }
    }
}
