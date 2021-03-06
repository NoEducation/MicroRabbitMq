using MicroRabbitMq.Transfer.Data.Context;
using MicroRabbitMq.Transfer.Domain.Interfaces;
using MicroRabbitMq.Transfer.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace MicroRabbitMq.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _context;
        public TransferRepository(TransferDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _context.TransferLogs.ToList();
        }

        public void AddTransfer(TransferLog target)
        {
            this._context.Add<TransferLog>(target);
            this._context.SaveChanges();
        }
    }
}
