﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turkcell.ECommerce.Web.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
    }
}