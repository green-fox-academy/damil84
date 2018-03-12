using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PallidaExam.Repositiries;


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
        public IActionResult SearchBrand([FromRoute]string brand)
        {
            return Json(new { result = "ok", data = carRepository.FilterBrand(brand) });
        }
    }
}
