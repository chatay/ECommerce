using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Entities.Concrete;

namespace Turkcell.ECommerce.Entities.Dtos
{
    public class BasketDto: DtoGetBase
    {
        public BasketItem BasketItems { get; set; }
    }
}
