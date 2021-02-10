using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProject>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProject context = new ReCapProject())
            {
                var result = from c in filter is null ? context.Cars : context.Cars.Where(filter)
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 ColorId = co.ColorId,
                                 BrandId = b.BrandId,
                                 ColorName = co.ColorName,
                                 BrandName = b.BrandName,
                                 DailyPrice = c.DailyPrice,
                                 Descriptions = c.Descriptions,
                                 ModelYear = c.ModelYear
                             };
                return result.ToList();
            }
        }
    }
}
