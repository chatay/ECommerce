using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Entities.Concrete;
using Turkcell.ECommerce.Entities.Dtos;

namespace Turkcell.ECommerce.Business.AutoMapper.Profiles
{
    public class ProductProfile: Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductAddDto, Product>().ForMember(dest=>dest.InsertedDateTime,
                opt=> opt.MapFrom(x=> DateTime.Now));
            CreateMap<ProductDto, Product>();
            CreateMap<BasketDto, BasketItem>();
            CreateMap<BasketAddDto, BasketItem>();
        }
    }
}
