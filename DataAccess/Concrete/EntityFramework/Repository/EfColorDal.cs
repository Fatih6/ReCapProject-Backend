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
    public class EfColorDal : IColorDal
    {
        public void add(Color entity)
        {
            using (ReCapProject context = new ReCapProject())
            {
                var addCarColor = context.Entry(entity);
                addCarColor.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (ReCapProject context = new ReCapProject())
            {
                var deleteCarColor = context.Entry(entity);
                deleteCarColor.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (ReCapProject context = new ReCapProject())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (ReCapProject context = new ReCapProject())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
        {
            using (ReCapProject context = new ReCapProject())
            {
                var updateCarColor = context.Entry(entity);
                updateCarColor.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
