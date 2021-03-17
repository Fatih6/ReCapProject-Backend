using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;


using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Concrete.EntityFramework.Context;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProject>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (ReCapProject context = new ReCapProject())
            {
                var result = from rental in filter is null ? context.Rentals : context.Rentals.Where(filter)

                             join car in context.Cars
                             on rental.CarId equals car.CarId

                             join customer in context.Customers
                             on rental.CustomerId equals customer.UserId

                             join user in context.Users
                             on customer.UserId equals user.Id

                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId

                             join color in context.Colors
                             on car.ColorId equals color.ColorId

                             orderby rental.Id
                             select new RentalDetailDto
                             {
                                 RentalId = rental.Id,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 CompanyName = customer.CompanyName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Descriptions,
                                 Email = user.Email,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 ModelYear = car.ModelYear
                             };
                return result.ToList();
            }
        }
    }
}