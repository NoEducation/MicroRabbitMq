using MediatR;

namespace MicroRabbitMq.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string Type { get; protected set; }

        protected Message()
        {
            Type = GetType().Name;
        }
    }
}
