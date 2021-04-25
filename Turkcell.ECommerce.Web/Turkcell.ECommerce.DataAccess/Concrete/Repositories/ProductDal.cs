using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Core.EntityFramework;
using Turkcell.ECommerce.DataAccess.Abstract;
using Turkcell.ECommerce.Entities.Concrete;

namespace Turkcell.ECommerce.DataAccess.Concrete
{
    public class ProductDal : RepositoryBase<Product, EnityFramWorkDbContext>, IProductDal
    {
        public ProductDal(EnityFramWorkDbContext context): base(context)
        {

        }
    }
}
