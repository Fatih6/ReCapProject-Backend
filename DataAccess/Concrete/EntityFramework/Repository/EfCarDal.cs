using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProject>, ICarDal
    {
        public List<CarDetailDto> GetAllCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProject context = new ReCapProject())
            {

                var result = from car in filter == null ? context.Cars : context.Cars.Where(filter)
                             join color in context.Colors on car.ColorId equals color.ColorId
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             select new CarDetailDto
                             {
                                 CarId = car.CarId,
                                 BrandName = brand.BrandName,
                                 Descriptions = car.Descriptions,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice
                             };
                return result.ToList();

            }
        }
    }
}