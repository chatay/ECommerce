﻿using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Core.Entities;

namespace Turkcell.ECommerce.DataAccess.Dto
{
    public class Product: IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
        public DateTime InsertedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int UserId { get; set; }
    }
}
