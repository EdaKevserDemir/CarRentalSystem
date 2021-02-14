using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarModels();

            // AddNewCar();

            // GetBrandIdTest();

            BrandManager brandManager=new BrandManager(new )
            
            Console.ReadLine();

        }

        private static void GetBrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(6))
            {
                Console.WriteLine(car.CarId + " " + car.ModelYear + " " + car.DailyPrice);
            }
        }

        private static void AddNewCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { CarId = 9, CarBrandId = 2, CarColorId = 2, DailyPrice = 1300, Description = "new car1", ModelYear = 2001 });

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + " : " + car.ColorName);
            }
        }

        private static void CarModels()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName +" "+car.BrandModel+" "+car.ModelYear+" "+car.ColorName);
            }
        }
    }

}
