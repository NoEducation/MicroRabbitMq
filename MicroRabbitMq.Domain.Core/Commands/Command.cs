using System;
using MicroRabbitMq.Domain.Core.Events;

namespace MicroRabbitMq.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }
        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
