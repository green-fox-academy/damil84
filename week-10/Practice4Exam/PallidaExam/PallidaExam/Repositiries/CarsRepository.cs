using PallidaExam.Entities;
using PallidaExam.Models;
using System.Collections.Generic;
using System.Linq;


namespace PallidaExam.Repositiries
{
    public class CarsRepository
    {
        private CarsContext carsContext;

        public CarsRepository(CarsContext carsContext)
        {
            this.carsContext = carsContext;
        }

        public List<Cars> GetCar()
        {
            return carsContext.Cars.ToList();
        }
    }
}