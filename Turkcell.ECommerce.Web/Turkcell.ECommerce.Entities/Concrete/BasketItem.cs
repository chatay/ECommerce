using System;
using System.Collections.Generic;
using System.Text;
using Turkcell.ECommerce.Core.Entities;

namespace Turkcell.ECommerce.Entities.Concrete
{
    public class BasketItem: IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
    }
}
