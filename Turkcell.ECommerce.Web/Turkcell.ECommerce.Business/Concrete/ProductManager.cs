using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Turkcell.ECommerce.Business.Abstract;
using Turkcell.ECommerce.Core.Shared.Utilities.Results;
using Turkcell.ECommerce.Core.Shared.Utilities.Results.Abstract;
using Turkcell.ECommerce.Core.Shared.Utilities.Results.Concrete;
using Turkcell.ECommerce.DataAccess.Abstract;
using Turkcell.ECommerce.DataAccess.Dto;
using Turkcell.ECommerce.Entities.Dtos;

namespace Turkcell.ECommerce.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal productDal;

        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public async Task<IResult> Add(ProductAddDto producAddDto)
        {
            await productDal.AddAsync(new Product
            {
                Id = Guid.NewGuid(),
                Name = producAddDto.Name,
                Price = producAddDto.Price,
                InsertedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now,
                UserId = 1
            }).ContinueWith(t => productDal.SaveAsync());
            await productDal.SaveAsync();
            return new Result(ResultStatus.Success, $"{producAddDto.Name} sipariş verildi");
        }

        public async Task<IDataResult<IList<Product>>> GetAll()
        {
            var products = await productDal.GetAllAsync(null);
            if (products.Count > 0)
            {
                return new DataResult<IList<Product>>(ResultStatus.Success, products);
            }
            return new DataResult<IList<Product>>(ResultStatus.Error, "none", null);
        }
    }
}
