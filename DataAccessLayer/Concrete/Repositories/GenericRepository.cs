
using DataAccessLayer.Abstract;
using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Insert(TEntity entity)
        {
            using (Context context = new Context())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (Context context = new Context())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (Context context = new Context())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public List<TEntity> List(Expression<Func<TEntity, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                return filter == null
                                 ? context.Set<TEntity>().ToList()
                                 : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (Context context = new Context())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Boolean Auth(Admin admin)
        {
            using (Context context = new Context())
            {
                var info = context.Admins.FirstOrDefault(x => x.User == admin.User
                && x.Password == admin.Password);
                if (info!=null)
                {
                    return true;
                }

                return false;
            }
            
        }

    }
}