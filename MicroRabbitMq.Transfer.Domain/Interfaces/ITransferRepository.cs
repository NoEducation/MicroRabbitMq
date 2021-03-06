using MicroRabbitMq.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbitMq.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
        void AddTransfer(TransferLog target);
    }
}
