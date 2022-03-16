using API.Core.Interfaces.Generic;
using API.Infrastructure.DataContext;
using System.Linq.Expressions;

namespace API.Infrastructure.Implementations.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly StoreDBContext _context;

        public GenericRepository(StoreDBContext context)
        {
            _context = context;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public T FindById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
