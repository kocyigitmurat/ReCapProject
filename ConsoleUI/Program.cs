using System;
using System.Collections.Generic;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            // Ekrana Yazdır
            Console.WriteLine("--------------- GetAll fonksiyonu ------------");
            consoleWrite(carManager.GetAll());

            Car car1 = new Car();
            car1.Id = 28;
            car1.BrandId = 3;
            car1.ColorId = 2;
            car1.DailyPrice = 570;
            car1.Description = "RENAULT";

            carManager.Add(car1);
            Console.WriteLine("--------------- Add fonksiyonu ------------");
            consoleWrite(carManager.GetAll());

            Car updateCar = new Car();
            updateCar.Id = 2;
            updateCar.BrandId = 99;
            updateCar.ColorId = 100;
            updateCar.DailyPrice = 1000;
            updateCar.Description = "VOLVO";

            Console.WriteLine("--------------- Update fonksiyonu ------------");
            carManager.Update(updateCar);
            consoleWrite(carManager.GetAll());

            Car deleteCar = new Car();
            deleteCar.Id = 3;

            Console.WriteLine("--------------- Delete fonksiyonu ------------");
            carManager.Delete(deleteCar);
            consoleWrite(carManager.GetAll());

            Console.WriteLine("--------------- GetById fonksiyonu ------------");
            Console.WriteLine(carManager.GetById(2).Description);

        }

        static void consoleWrite(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("---------------------------------");
        }
    }
}
