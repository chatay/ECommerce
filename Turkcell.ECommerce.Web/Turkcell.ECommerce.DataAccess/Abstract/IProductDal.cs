using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Core.DataAccess;
using Turkcell.ECommerce.DataAccess.Dto;

namespace Turkcell.ECommerce.DataAccess.Abstract
{
    public interface IProductDal: IRepository<Product>
    {
    }
}
