using MicroRabbitMq.Domain.Core.Bus;
using MicroRabbitMq.Transfer.Domain.Events;
using System.Threading.Tasks;

namespace MicroRabbitMq.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        public TransferEventHandler()
        {
            
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}
