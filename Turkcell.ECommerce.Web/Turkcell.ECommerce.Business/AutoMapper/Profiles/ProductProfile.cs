using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.DataAccess.Dto;
using Turkcell.ECommerce.Entities.Dtos;

namespace Turkcell.ECommerce.Business.AutoMapper.Profiles
{
    public class ProductProfile: Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductAddDto, Product>().ForMember(dest=>dest.InsertedDateTime,
                opt=> opt.MapFrom(x=> DateTime.Now));
            CreateMap<ProductGetDto, Product>();
        }
    }
}
