using MicroRabbitMq.Banking.Domain.Models;
using System.Collections.Generic;
using MicroRabbitMq.Banking.Application.Models;

namespace MicroRabbitMq.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
