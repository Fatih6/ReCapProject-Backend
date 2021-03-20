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
        public List<RentalDetailDto> GetAllRentalDetails()
        {
            using (ReCapProject context = new ReCapProject())
            {
                var result = from rent in context.Rentals
                             join car in context.Cars
                             on rent.CarId equals car.CarId
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join customer in context.Customers
                             on rent.CustomerId equals customer.Id
                             join user in context.Users
                             on customer.UserId equals user.Id
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             select new RentalDetailDto
                             {
                                 RentalId = rent.Id,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 CompanyName = customer.CompanyName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Descriptions,
                                 Email = user.Email,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 ModelYear = car.ModelYear,
                                 RentDate = rent.RentDate,
                                 RentStartDate = rent.RentStartDate,
                                 RentEndDate = rent.RentEndDate,
                                 ReturnDate = rent.ReturnDate

                             };
                return result.ToList();
            }
        }
    }
}