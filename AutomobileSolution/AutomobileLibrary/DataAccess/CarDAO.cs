using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    public class CarDAO
    {
        private static CarDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CarDAO Instance{
            get { 
                lock(instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new CarDAO();
                    }
                }
                return instance; 
            }
        }
        public IEnumerable<Car> GetCars()
        {
            var cars = new List<Car>();
            try
            {
                using var context = new MyStockContext();
                cars = context.Cars.ToList();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cars;
        }

        public Car GetCarByID(int id)
        {
            Car car = null;
            try
            {
                using var context = new MyStockContext();
                car = context.Cars.SingleOrDefault(c => c.CarId == id);
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return car;
        }

        public void InsertCar(Car car )
        {
            
            try
            {
                Car _car = GetCarByID(car.CarId);
                if (_car != null)
                {
                    using var context = new MyStockContext();
                    context.Cars.Add(car);
                }
                else
                {
                    throw new Exception("Car is exsited");
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message); 
            }
            
        }

        public void DeleteCar(int id)
        {
            try
            {
                Car car = GetCarByID(id);
                if (car != null)
                {
                    using var context = new MyStockContext();
                    context.Cars.Remove(car);   
                }
                else
                {
                    throw new Exception("NOT FOUND CAR");
                }

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
