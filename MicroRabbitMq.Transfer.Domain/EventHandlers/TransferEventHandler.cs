using MicroRabbitMq.Domain.Core.Bus;
using MicroRabbitMq.Transfer.Domain.Events;
using MicroRabbitMq.Transfer.Domain.Interfaces;
using MicroRabbitMq.Transfer.Domain.Models;
using System.Threading.Tasks;

namespace MicroRabbitMq.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;
        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.AddTransfer(new TransferLog()
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmount = @event.Amount
            });

            return Task.CompletedTask;
        }
    }
}
