using Turkcell.ECommerce.Core.DataAccess;
using Turkcell.ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Turkcell.ECommerce.DataAccess.Abstract
{
    public interface IBasketDal : IRepository<BasketItem>
    {
    }
}
