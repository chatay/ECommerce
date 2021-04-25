using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Entities.Concrete;

namespace Turkcell.ECommerce.Entities.Dtos
{
    public class BasketAddDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
    }
}
