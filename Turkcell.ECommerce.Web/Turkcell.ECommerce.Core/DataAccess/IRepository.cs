using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Turkcell.ECommerce.Core.Entities;

namespace Turkcell.ECommerce.Core.DataAccess
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        Task AddAsync(T entity);
        Task SaveAsync();
        Task<IEnumerable<T>> GetAllBasketItemsAsync(Expression<Func<T, bool>> filter = null);
        TEntity GetById<TEntity>(object id)
           where TEntity : class;
    }
}
