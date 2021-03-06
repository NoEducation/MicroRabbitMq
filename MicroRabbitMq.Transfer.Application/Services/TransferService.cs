using MicroRabbitMq.Banking.Domain.Interfaces;
using MicroRabbitMq.Domain.Core.Bus;
using MicroRabbitMq.Transfer.Application.Interfaces;
using MicroRabbitMq.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbitMq.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;
        public TransferService(ITransferRepository transferRepository,
            IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return this._transferRepository.GetTransferLogs();
        }
    }
}
