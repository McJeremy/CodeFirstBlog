using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace XZZ.Fk.Core
{
    public interface IRepository<T> where T:Entity
    {
        IQueryable<T> GetList(Expression<Func<T, bool>> predicate = null);
        Task<long> Count();
        T Get(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
