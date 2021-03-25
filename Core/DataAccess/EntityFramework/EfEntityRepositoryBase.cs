using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext , new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addCar = context.Entry(entity);
                addCar.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deleteCar = context.Entry(entity);
                deleteCar.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                if (filter == null)
                {
                    return context.Set<TEntity>().ToList();

                }
                else
                {
                    return context.Set<TEntity>().Where(filter).ToList();
                }
                //var result = filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
                //return result;
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updateCar = context.Entry(entity);
                updateCar.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
