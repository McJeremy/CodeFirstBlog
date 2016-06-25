using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using XZZ.Fk.Core;

namespace XZZ.Fk.DAL
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly CodeFirstBlogContext _context = null;
        private readonly DbSet<T> _dbSet;
        public Repository(CodeFirstBlogContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task<long> Count()
        {
            return await _dbSet.LongCountAsync<T>();
        }

        public void Delete(T entity)
        {
             _dbSet.Remove(entity);
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Single<T>(predicate);            
        }

        public IQueryable<T> GetList(Expression<Func<T, bool>> predicate = null)
        {
            return _dbSet.Where<T>(predicate);
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
