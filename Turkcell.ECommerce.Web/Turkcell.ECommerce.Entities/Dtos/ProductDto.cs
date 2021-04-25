using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Entities.Concrete;

namespace Turkcell.ECommerce.Entities.Dtos
{
    public class ProductDto: DtoGetBase
    {
        public Product Product { get; set; }
    }
}
