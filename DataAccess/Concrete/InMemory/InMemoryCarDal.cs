using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{ Id = 1, BrandId = 1, ColorId = 1, ModelYear = "2020", DailyPrice = 350, Description = "BMW" },
                new Car{ Id = 2, BrandId = 2, ColorId = 1, ModelYear = "2019", DailyPrice = 250, Description = "Mercedes" },
                new Car{ Id = 3, BrandId = 2, ColorId = 2, ModelYear = "2018", DailyPrice = 500, Description = "Ford" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetByID(int id)
        {
            Car selectedCar = _cars.SingleOrDefault(c => c.Id == id);

            return selectedCar;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
