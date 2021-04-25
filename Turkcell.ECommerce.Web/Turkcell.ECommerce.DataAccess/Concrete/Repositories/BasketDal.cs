using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Core.EntityFramework;
using Turkcell.ECommerce.DataAccess.Abstract;
using Turkcell.ECommerce.Entities.Concrete;

namespace Turkcell.ECommerce.DataAccess.Concrete.Repositories
{
    public class BasketDal: RepositoryBase<BasketItem, EnityFramWorkDbContext>, IBasketDal
    {
        public BasketDal(EnityFramWorkDbContext context) : base(context)
        {

        }
    }
}
