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

        public List<Cars> FilterPlates(string plateNumber)
        {
            return carsContext.Cars.Where(car => car.LicencePlate.Contains(plateNumber)).ToList();
        }


    }
}
