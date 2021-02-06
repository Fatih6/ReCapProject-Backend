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
    public class EfBrandDal : IBrandDal
    {
        public void add(Brand entity)
        {
            using (ReCapProject context = new ReCapProject())
            {
                var addBrand = context.Entry(entity);
                addBrand.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (ReCapProject context = new ReCapProject())
            {
                var deleteBrand = context.Entry(entity);
                deleteBrand.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (ReCapProject context = new ReCapProject())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (ReCapProject context = new ReCapProject())
            {
                return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
        {
            using (ReCapProject context = new ReCapProject())
            {
                var updateBrand = context.Entry(entity);
                updateBrand.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
