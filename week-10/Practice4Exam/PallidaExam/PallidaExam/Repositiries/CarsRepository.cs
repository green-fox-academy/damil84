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

        public List<Cars> GetCar(string plateNumber, string police, string diplomat)
        {
            if (plateNumber == "1")
                return carsContext.Cars.Where(car => car.LicencePlate.Contains(plateNumber)).ToList();
            else if (police == "1")
                return carsContext.Cars.Where(car => car.LicencePlate.StartsWith("RB")).ToList();
            else if (diplomat == "1")
                return carsContext.Cars.Where(car => car.LicencePlate.StartsWith("DT")).ToList();
            else
                return carsContext.Cars.ToList();
        }

        public List<Cars> FilterBrand(string brand)
        {
            return carsContext.Cars.Where(car => car.Brand.Equals(brand)).ToList();
        }
    }
}