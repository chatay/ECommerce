using MassTransit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Turkcell.ECommerce.MessageContracts
{
    public class RegisterMessageCommandConsumer: IConsumer<IRegisterMessageCommand>
    {
        public Task Consume(ConsumeContext<IRegisterMessageCommand> context)
        {
            var message = context.Message;
            var guid = Guid.NewGuid();
            Console.WriteLine($"Message successfully  registered. Subject:{message.Email}, Description:{message.Message}, Id:{guid}");
            context.Publish<IRegisteredDemandEvent>(new
            {
                DemandId = guid
            });
            return Task.CompletedTask;
        }
    }
}
