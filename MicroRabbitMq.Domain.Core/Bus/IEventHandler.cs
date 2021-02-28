using System.Threading.Tasks;
using MicroRabbitMq.Domain.Core.Events;

namespace MicroRabbitMq.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
        where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {}
}
