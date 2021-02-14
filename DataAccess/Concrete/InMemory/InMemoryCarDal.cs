using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,CarBrandId=1,CarColorId=1,ModelYear=2012,DailyPrice=300,Description="Has damage."},
                new Car{CarId=2,CarBrandId=1,CarColorId=2,ModelYear=2016,DailyPrice=500,Description="No damage."},
                new Car{CarId=3,CarBrandId=2,CarColorId=3,ModelYear=2018,DailyPrice=800,Description="Has damage."},
                new Car{CarId=4,CarBrandId=2,CarColorId=3,ModelYear=2018,DailyPrice=750,Description="No damage."},
                new Car{CarId=5,CarBrandId=3,CarColorId=4,ModelYear=2020,DailyPrice=1500,Description="No damage."},
                new Car{CarId=6,CarBrandId=4,CarColorId=4,ModelYear=2021,DailyPrice=2500,Description="No damage."},
                new Car{CarId=7,CarBrandId=6,CarColorId=5,ModelYear=2010,DailyPrice=200,Description="Has damage."}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }
    
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.CarBrandId = car.CarBrandId;
            carToUpdate.CarColorId = car.CarColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description=car.Description;

               
           
        }
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
