using GreenPipes;
using MassTransit;
using System;
using System.Threading.Tasks;
using Turkcell.ECommerce.MessageContracts;

namespace Turkcell.ECommerce.Notification
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var bus = BusConfigurator.ConfigureBus((cfg, host) =>
            {
                cfg.ReceiveEndpoint(
                    RabbitMqConsts.RegisterDemandServiceQueue, e =>
                    {
                        e.Consumer<RegisterMessageCommandConsumer>();
                        e.UseCircuitBreaker(cb =>
                        {
                            cb.TrackingPeriod = TimeSpan.FromMinutes(1);
                            cb.TripThreshold = 15;
                            cb.ActiveThreshold = 10;
                            cb.ResetInterval = TimeSpan.FromMinutes(5);
                        });

                    });

            });
            await bus.StartAsync();
            await Task.Run(() => Console.ReadLine());
            await bus.StopAsync();
        }
    }
}
