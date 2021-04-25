using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
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
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal basketDal;
        private readonly IMapper _mapper;
        public BasketManager(IBasketDal basketDal, IMapper mapper)
        {
            this.basketDal = basketDal;
            _mapper = mapper;
        }

        public async Task<IResult> Add(BasketAddDto basketAddDto)
        {
            //var basket = _mapper.Map<BasketItem>(basketAddDto);
            var basket = new BasketItem
            {
                ProductId = basketAddDto.ProductId,
                Quantity = basketAddDto.Quantity,
                UserId = 1
            };
            await basketDal.AddAsync(basket);

            return new Result(ResultStatus.Success, $"{basketAddDto.Quantity} sipariş verildi");
        }
        public async Task<IList<BasketItem>> GetBasketItems()
        {
            var basketItems = await basketDal.GetAllAsync();
            basketItems = PopulateProductIntoBasketItem(basketItems.ToList());
            return basketItems.ToList();
        }

        private List<BasketItem> PopulateProductIntoBasketItem(List<BasketItem> basketItems)
        {
            foreach (var basketItem in basketItems)
            {
                basketItem.Product = basketDal.GetById<Product>(basketItem.ProductId);
            }

            return basketItems;
        }
    }
}
