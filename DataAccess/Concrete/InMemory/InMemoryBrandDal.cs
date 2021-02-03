using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;

        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand {BrandId=1,BrandName="BMW"},
                new Brand{BrandId=2,BrandName="Mercedes"},
                new Brand{BrandId=3,BrandName="Renault"},
                new Brand{BrandId=4, BrandName="Toyota"}
            };

        }


        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }
        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brands.FirstOrDefault(b=>b.BrandId==brand.BrandId);
            brandToUpdate.BrandId = brand.BrandId;
            brandToUpdate.BrandName = brand.BrandName;
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(b=>b.BrandId==brand.BrandId);
            _brands.Remove(brandToDelete);
        }

        public List<Brand> GetAll()
        {
           return _brands;
        }

        public List<Brand> GetById(int brandId)
        {
           return _brands.Where(b => b.BrandId == brandId).ToList();
        }

        
    }
}
