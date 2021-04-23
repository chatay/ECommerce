using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Turkcell.ECommerce.Core.Shared.Utilities.Results;
using Turkcell.ECommerce.Core.Shared.Utilities.Results.Abstract;
using Turkcell.ECommerce.DataAccess.Dto;
using Turkcell.ECommerce.Entities.Dtos;

namespace Turkcell.ECommerce.Business.Abstract
{
    interface IProductService
    {
        Task<IDataResult<IList<Product>>> GetAll();
        Task<IResult> Add(ProductAddDto producAddDto);
    }
}
