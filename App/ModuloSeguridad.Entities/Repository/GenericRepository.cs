using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ModuloSeguridad.Entities.Repository
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        internal ModuloSeguridadContext context;
        internal DbSet<TEntity> entities;

        public GenericRepository(ModuloSeguridadContext context)
        {
            this.context = context;
            entities = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(
                Expression<Func<TEntity, bool>> expression = null,
                Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                string includeProperties = ""
            )
        {
            IQueryable<TEntity> entities = this.entities;
            if (expression != null) entities = entities.Where(expression);
            foreach (var item in includeProperties.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries))
            {
                entities = entities.Include(item);
            }
            if (orderBy != null) return orderBy(entities).ToList();
            else return entities.ToList();
        }

        public virtual TEntity Get(object id)
        {
            return entities.Find(id);
        }

        public virtual void Crear(TEntity entity)
        {
            entities.Add(entity);
        }

        public virtual void Eliminar(object id)
        {
            Eliminar(entities.Find(id));
        }

        public virtual void Eliminar(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached) entities.Attach(entity);
            entities.Remove(entity);
        }

        public virtual void Actualizar(TEntity entity)
        {
            entities.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
