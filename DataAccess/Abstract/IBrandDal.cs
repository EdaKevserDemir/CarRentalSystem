using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IBrandDal
    {
        List<Brand> GetAll();
        List<Brand> GetById(int brandId);

        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);

    }
}
