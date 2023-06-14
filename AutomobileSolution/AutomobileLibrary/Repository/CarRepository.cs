using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public void DeleteCar(int carId)
        {
           
        }

        public Car GetCarByID(int carId) => CarDAO.Instance.GetCarByID(carId);

        public IEnumerable<Car> GetCars() => CarDAO.Instance.GetCars();

        public void InsertCar(Car car)
        {
            throw new NotImplementedException();
        }

        public void UpdateCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
