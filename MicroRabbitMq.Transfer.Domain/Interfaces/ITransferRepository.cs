using MicroRabbitMq.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbitMq.Banking.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
