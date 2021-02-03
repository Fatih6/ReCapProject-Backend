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
               new Brand { BrandId = 1, BrandName = "Mercedes" },
               new Brand { BrandId = 2, BrandName = "Tesla" },
               new Brand { BrandId = 3, BrandName = "BMW" },
               new Brand { BrandId = 4, BrandName = "Rang Rover" },
               new Brand { BrandId = 5, BrandName = "Ford" },
               new Brand { BrandId = 6, BrandName = "Mitsubishi" }
            };
        }
        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            var brandToDelete = _brands.SingleOrDefault(b=>b.BrandId == brand.BrandId);
            _brands.Remove(brandToDelete);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public Brand GetById(int BrandId)
        {
            return _brands.SingleOrDefault(b=>b.BrandId == BrandId);
        }

        public void Update(Brand brand)
        {
            var brandToUpdate = _brands.SingleOrDefault(b=>b.BrandId == brand.BrandId);
            brandToUpdate.BrandName = brand.BrandName;
        }
    }
}
