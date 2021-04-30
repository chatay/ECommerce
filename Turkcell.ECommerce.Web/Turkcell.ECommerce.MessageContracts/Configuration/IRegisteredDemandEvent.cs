using System;

namespace Turkcell.ECommerce.MessageContracts
{
    public interface IRegisteredDemandEvent
    {
        public Guid DemandId { get; set; }
    }
}
