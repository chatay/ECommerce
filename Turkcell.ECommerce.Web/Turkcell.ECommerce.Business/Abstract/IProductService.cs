using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Turkcell.ECommerce.Core.Shared.Utilities.Results.Abstract;
using Turkcell.ECommerce.Entities.Concrete;
using Turkcell.ECommerce.Entities.Dtos;

namespace Turkcell.ECommerce.Business.Abstract
{
    public interface IProductService
    {
        Task<IDataResult<ProductDto>> Get(int productId);
        Task<IDataResult<IList<Product>>> GetAll();
    }
}
