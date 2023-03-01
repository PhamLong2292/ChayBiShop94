using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ChayBiShop94.Repositories.Interfaces
{
    public interface IGenericRepository<T>: IDisposable
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null,Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProprtyies = "");
        T GetById(object id);
        Task<T> GetByIdAsync(object id);
        void Update(T entity);
        void Delete(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
