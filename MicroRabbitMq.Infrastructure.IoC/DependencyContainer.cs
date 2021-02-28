using MicroRabbitMq.Domain.Core.Bus;
using MicroRabbitMq.Infrastructure.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbitMq.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitMqBus>();
        }
    }
}
