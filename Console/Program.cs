using Business.Concrete;
using DataAccess.Abstract;
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
            Console.WriteLine("GetAll Process");
            CarManager carManager = new CarManager(new InMemoryCarDal());
            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId+" "+car.BrandId + " " +car.ColorId+" "+ car.ModelYear + " " + car.DailyPrice+ " "+car.Description);
            }

            Console.WriteLine("Get Brand Data Process");
            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine( brand.BrandId + " " +brand.BrandName);

            }
            Console.WriteLine("Add new Color Process");

            ColorManager colorManager = new ColorManager(new InMemoryColorDal());
            IColorDal colorDal = new InMemoryColorDal();
            colorDal.Add(new Color { ColorId = 5, ColorName = "White" });

            foreach (var color in colorDal.GetAll())
            {
                Console.WriteLine(color.ColorId + " " + color.ColorName);
            }

            Console.WriteLine("Delete Process");

            ICarDal carDal = new InMemoryCarDal();
            carDal.Delete(new Car { CarId=2});
            foreach (var car in carDal.GetAll())
            {
                Console.WriteLine(car.CarId + " " +car.ColorId+" "+car.BrandId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }

            Console.WriteLine("Update Process");
            carDal.Update(new Car { CarId=3,BrandId=2,ColorId=4,ModelYear=2025,DailyPrice=2000,Description="Auto"});

            foreach (var car in carDal.GetAll())
            {
                Console.WriteLine(car.CarId + " " + car.ColorId+" " + car.BrandId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }

            Console.ReadLine();
        }

    }

}

