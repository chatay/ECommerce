using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Turkcell.ECommerce.Entities.Dtos
{
    public class ProductAddDto
    {
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Fiyatı")]
        public decimal Price { get; set; }
    }
}
