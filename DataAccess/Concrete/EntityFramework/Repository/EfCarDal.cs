using Core.DataAccess.EntityFramework;
using Core.Extensions;
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
        public List<CarDetailDto> GetAllCarDetailsByFilter(CarDetailFilterDto filterDto)
        {
            using (ReCapProject context = new ReCapProject())
            {
                var filterExpression = filterDto.GetFilterExpression<Car>();
                var result = from car in filterExpression == null ? context.Cars : context.Cars.Where(filterExpression)
                             join color in context.Colors on car.ColorId equals color.ColorId
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             select new CarDetailDto
                             {
                                 CarId = car.CarId,
                                 BrandId = brand.BrandId,
                                 ColorId = color.ColorId,
                                 BrandName = brand.BrandName,
                                 Descriptions = car.Descriptions,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear
                             };
                return result.ToList();

            }
        }
    }
}