using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Turkcell.ECommerce.Core.DataAccess;
using Turkcell.ECommerce.Core.Entities;

namespace Turkcell.ECommerce.Core.EntityFramework
{
    public class RepositoryBase<Tentity, TContext> : IRepository<Tentity>
        where Tentity : class, IEntity, new()
        where TContext: DbContext
    {
        private readonly DbContext _context;
        public RepositoryBase(DbContext _context)
        {
            this._context = _context;
        }
        public async Task AddAsync(Tentity entity)
        {
           await _context.Set<Tentity>().AddAsync(entity);
        }
        public async Task<Tentity> GetAsync(Expression<Func<Tentity, bool>> filter)
        {
            IQueryable<Tentity> query = _context.Set<Tentity>();
            if (filter != null)
            {
                query = query.Where(filter);
            }

            return await query.SingleOrDefaultAsync();
        }

        public async Task<IList<Tentity>> GetAllAsync(Expression<Func<Tentity, bool>> filter = null)
        {
            IQueryable<Tentity> query = _context.Set<Tentity>();
            if (filter != null)
            {
                query = query.Where(filter);
            }

            return await query.ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}