using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Turkcell.ECommerce.Business.Abstract;
using Turkcell.ECommerce.Core.Shared.Utilities.Results.Abstract;
using Turkcell.ECommerce.Core.Shared.Utilities.Results.ComplexTypes;
using Turkcell.ECommerce.Core.Shared.Utilities.Results.Concrete;
using Turkcell.ECommerce.DataAccess.Abstract;
using Turkcell.ECommerce.Entities.Concrete;
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
        public async Task<IDataResult<ProductDto>> Get(int productId)
        {
            var product = await productDal.GetAsync(c => c.Id == productId);
            if (product != null)
            {
                return new DataResult<ProductDto>(ResultStatus.Success, new ProductDto
                {
                    Product = product,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductDto>(ResultStatus.Error, "Böyle bir ürün bulunamadı.", null);
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
