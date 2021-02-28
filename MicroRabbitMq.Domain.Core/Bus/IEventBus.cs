using System.Threading.Tasks;
using MicroRabbitMq.Domain.Core.Commands;
using MicroRabbitMq.Domain.Core.Events;

namespace MicroRabbitMq.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command)
            where T : Command;

        void PublishEvent<T>(T @event)
            where T : Event;

        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
