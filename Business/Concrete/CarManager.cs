using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {           

            return _carDal.GetAll();

        }
        public void Add(Car car)
        {
            if(car.Description.Length>2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("New car added!");
            }
            else
            {
                Console.WriteLine("Please check your data! ");
            }
        }
        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c=>c.CarBrandId==brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c=>c.CarColorId==colorId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
