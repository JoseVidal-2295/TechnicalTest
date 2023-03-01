using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCrudTest.Model.Core
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get();
        TEntity GetById(int entityId);
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
     
    }
}
