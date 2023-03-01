using CustomerCrudTest.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudTest.Model.Core
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly CustomerContext _context;
        private DbSet<TEntity> _entities;

        public BaseRepository(CustomerContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Get()
        {
            return _entities.ToList();
        }

        public TEntity GetById(int entityId)
        {
            return _entities.Find(entityId);
        }

        public void Remove(TEntity entity)
        {
            
            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public void Save(TEntity entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _entities.Update(entity);
            _context.SaveChanges();
        }
    }
}
