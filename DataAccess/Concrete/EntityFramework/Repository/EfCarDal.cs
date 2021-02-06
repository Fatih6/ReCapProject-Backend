using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfCarDal : ICarDal
    {
        public void add(Car entity)
        {
            using (ReCapProject context = new ReCapProject())
            {
                var addCar = context.Entry(entity);
                addCar.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapProject context = new ReCapProject())
            {
                var deleteCar = context.Entry(entity);
                deleteCar.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapProject context = new ReCapProject())
            {
                return context.Set<Car>().SingleOrDefault();
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProject context = new ReCapProject())
            {
                if (filter == null)
                {
                    return context.Set<Car>().ToList();

                }
                else
                {
                    return context.Set<Car>().Where(filter).ToList();
                }
                //var result = filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
                //return result;
            }
        }

        public void Update(Car entity)
        {
            using (ReCapProject context = new ReCapProject())
            {
                var updateCar = context.Entry(entity);
                updateCar.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
