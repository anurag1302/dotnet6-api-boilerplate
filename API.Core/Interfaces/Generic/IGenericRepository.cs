using System.Linq.Expressions;

namespace API.Core.Interfaces.Generic
{
    public interface IGenericRepository<T>
    {
        IQueryable<T> GetAll();
        T FindById(int id);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();
    }
}
