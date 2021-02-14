using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal //veritabanı operasyonları yazılmaya hazır.
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.CarBrandId equals b.BrandId
                             join clr in context.Colors
                             on c.CarColorId equals clr.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,                                
                                 BrandName = b.BrandName,
                                 BrandModel = b.BrandModel,
                                 ColorName = clr.ColorName,
                                 DailyPrice = c.DailyPrice,                               
                                 Description=c.Description,
                                 ModelYear=c.ModelYear
                             };
                return result.ToList();
            }
        }

    }


}
