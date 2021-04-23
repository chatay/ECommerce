using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.DataAccess.Dto;

namespace Turkcell.ECommerce.Entities.Dtos
{
    public class ProductGetDto
    {
        public IList<Product> product { get; set; }
    }
}
