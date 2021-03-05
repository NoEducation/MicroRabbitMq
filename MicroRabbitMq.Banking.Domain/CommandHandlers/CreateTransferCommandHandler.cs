using MediatR;
using MicroRabbitMq.Banking.Domain.Commands;
using System;
using System.Threading;
using System.Threading.Tasks;
using MicroRabbitMq.Banking.Domain.Events;
using MicroRabbitMq.Domain.Core.Bus;

namespace MicroRabbitMq.Banking.Domain.CommandHandlers
{
    public class CreateTransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;
        public CreateTransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            _bus.PublishEvent(new TransferCreatedEvent(request.From, request.To, request.Amount));
            return Task.FromResult(true);
        }
    }
}
