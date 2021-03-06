using System.Collections.Generic;
using MicroRabbitMq.Transfer.Domain.Models;

namespace MicroRabbitMq.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
